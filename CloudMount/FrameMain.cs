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
                    gcp = new GcpModel();
                    gcp.credentialsFilePath = d.gcpCredsPath;
                    gcp.projectId = d.gcpProjectId;

                    var creds = GoogleCredential.FromFile(gcp.credentialsFilePath);
                    using (StorageClient storage = StorageClient.Create(creds))
                    {
                        var buckets = storage.ListBuckets(gcp.projectId);
                        foreach (var bucket in buckets)
                        {
                            Console.WriteLine(bucket.Name);
                            foreach (var item in storage.ListObjects(bucket.Name))
                            {
                                Console.WriteLine(item.Name);
                            }
                        }
                    }
                }
            }
        }

        private void FrameMain_Load(object sender, EventArgs e)
        {
           
        }
    }
}
