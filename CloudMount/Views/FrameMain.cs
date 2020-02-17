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
        private AwsDataModel aws;
        private GcpDataModel gcp;
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
                    aws = new AwsDataModel();

                }
                else if (cloudType == CloudTypeEnum.GCP)
                {
                    try
                    {
                        gcp = new GcpDataModel();
                        gcp.credentialsFilePath = d.gcpCredsPath;
                        gcp.projectId = d.gcpProjectId;

                        var creds = GoogleCredential.FromFile(gcp.credentialsFilePath);
                        gcp.client = StorageClient.Create(creds);
                        fs = CloudFileSystemIngestor.IngestGcp(gcp);
                    }
                    catch (Exception ex)
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
            // TODO
            if (cloudType == CloudTypeEnum.AWS)
            {

            }
            else if(cloudType == CloudTypeEnum.GCP)
            {
           
            }
        }
    }
}
