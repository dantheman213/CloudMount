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
        private CloudFileSystem fs;
        private CloudFileSystemNode currentDirectoryNode;

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
           
        }

        private void IngestCloudFs(string bucketName)
        {
            if (cloudType == CloudTypeEnum.GCP)
            {
                foreach (var obj in gcp.client.ListObjects(bucketName))
                {
                    Console.WriteLine(obj.Name);
                }
            }
        }
    }
}
