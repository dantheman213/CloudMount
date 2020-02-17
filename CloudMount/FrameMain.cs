using System;
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
            if (listFiles.SelectedItems.Count == 1)
            {
                var item = listFiles.SelectedItems[0];
                if (item.Tag.ToString() == "bucket")
                {
                    foreach (var obj in gcp.client.ListObjects(item.Text))
                    {
                        Console.WriteLine(obj.Name);

                    }
                }
            }
        }
    }
}
