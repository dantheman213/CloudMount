using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;

namespace CloudMount
{
    public partial class FrameMain : Form
    {
        private CloudTypeEnum cloudType;
        private AwsModel aws;
        private GcpModel gcp;
        private string currentPath;
        private List<string> fs;

        public FrameMain()
        {
            InitializeComponent();
        }
        
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var d = new FrameConnect();
            if (d.ShowDialog() == DialogResult.OK)
            {
                cloudType = d.type;
                if(cloudType == CloudTypeEnum.AWS)
                {
                    // TODO
                    aws = new AwsModel();

                }
                else if (cloudType == CloudTypeEnum.GCP)
                {
                    try
                    {
                        gcp = new GcpModel();
                        gcp.credentialsFilePath = d.gcpCredsPath;
                        gcp.projectId = d.gcpProjectId;

                        var creds = GoogleCredential.FromFile(gcp.credentialsFilePath);
                        gcp.client = StorageClient.Create(creds);

                        var buckets = gcp.client.ListBuckets(gcp.projectId);
                        foreach (var bucket in buckets)
                        {
                            Console.WriteLine(bucket.Name);
                            listFiles.Items.Add(bucket.Name, 0);
                            listFiles.Items[listFiles.Items.Count - 1].Tag = "bucket";
                        }
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void FrameMain_Load(object sender, EventArgs e)
        {
           
        }

        private void listFiles_DoubleClick(object sender, EventArgs e)
        {
            if (cloudType == CloudTypeEnum.AWS)
            {

            }
            else if(cloudType == CloudTypeEnum.GCP)
            {
                listFiles_GCP_DoubleClick(sender, e);
            }
        }

        private void listFiles_GCP_DoubleClick(object sender, EventArgs e)
        {
            if (listFiles.SelectedItems.Count == 1)
            {
                var item = listFiles.SelectedItems[0];
                if (item.Tag.ToString() == "bucket")
                {
                    IngestCloudFs(item.Text);

                    List<string> collection = new List<string>();
                    listFiles.Items.Clear();
                    foreach (var obj in fs)
                    {
                        var parts = obj.Split('/');
                        if (collection.Find(x => x == parts[0]) == null)
                        {
                            collection.Add(parts[0]);
                            if (parts.Length > 1)
                            {
                                // directory
                                listFiles.Items.Add(parts[0], 0);
                                listFiles.Items[listFiles.Items.Count - 1].Tag = "directory";
                            }
                            else
                            {
                                // file
                                listFiles.Items.Add(parts[0], 1);
                                listFiles.Items[listFiles.Items.Count - 1].Tag = "file";
                            }
                        }
                    }
                }
                else if (item.Tag.ToString() == "directory")
                {

                }
                else if (item.Tag.ToString() == "file")
                {

                }
            }
        }

        private void IngestCloudFs(string bucketName)
        {
            fs = new List<string>();
            if (cloudType == CloudTypeEnum.GCP)
            {
                foreach (var obj in gcp.client.ListObjects(bucketName))
                {
                    Console.WriteLine(obj.Name);
                    fs.Add(obj.Name);
                }
            }
        }
    }
}
