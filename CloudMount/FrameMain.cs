using System;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;

namespace CloudMount
{
    public partial class FrameMain : Form
    {
        public FrameMain()
        {
            InitializeComponent();
        }

        private void connectToGCPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void connectToAWSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var d = new FrameConnectAWS();
            if (d.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void FrameMain_Load(object sender, EventArgs e)
        {
            string projectId = "TODO";
            var creds = GoogleCredential.FromFile("C:\\Users\\myuser\\.config\\gcloud.json");
            using (StorageClient storage = StorageClient.Create(creds))
            {
                var buckets = storage.ListBuckets(projectId);
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
