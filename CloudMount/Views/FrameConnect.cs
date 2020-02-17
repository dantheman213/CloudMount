using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudMount
{
    public partial class FrameConnect : Form
    {
        public CloudTypeEnum type = CloudTypeEnum.None;
        public string gcpCredsPath;
        public string gcpProjectId;

        public FrameConnect()
        {
            InitializeComponent();
        }

        private void buttonBrowseGCPCreds_Click(object sender, EventArgs e)
        {
            var d = new OpenFileDialog();
            d.Filter = "JSON file (*.json)|*.json";
            if (d.ShowDialog() == DialogResult.OK)
            {
                textGCPCredsFilepath.Text = d.FileName;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            // TODO: error checking
            if (tabControl.SelectedTab == tabAWS)
            {
                // TODO
                type = CloudTypeEnum.AWS;
            }
            else if(tabControl.SelectedTab == tabGCP)
            {
                type = CloudTypeEnum.GCP;
                gcpCredsPath = textGCPCredsFilepath.Text;
                gcpProjectId = textGCPProjectId.Text;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
