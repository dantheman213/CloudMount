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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    fs = CloudFileSystemIngestor.IngestGcp(gcp);
                    currentDirectoryNode = fs.GetRootNode();
                    loadListFilesAtDirPath(currentDirectoryNode.AbsolutePath);
                }
            }
        }

        private void loadListFilesAtDirPath(string path)
        {
            var node = fs.FindNodeAtAbsolutePath(path);
            if (node != null && node.Children != null && node.Children.Count > 0)
            {
                currentDirectoryNode = node;

                listFiles.Items.Clear();
                foreach(var child in node.Children)
                {
                    int imageIndex = 0;
                    if (child.Type == CloudFileSystemNodeTypeEnum.BUCKET || child.Type == CloudFileSystemNodeTypeEnum.DIRECTORY)
                    {
                        imageIndex = 0;
                    }
                    else if (child.Type == CloudFileSystemNodeTypeEnum.FILE)
                    {
                        imageIndex = 1;
                    }

                    var listItem = new ListViewItem(child.Name, imageIndex);
                    listItem.Tag = child;
                    listFiles.Items.Add(listItem);
                }

                updatePathUi();
            }
        }

        private void FrameMain_Load(object sender, EventArgs e)
        {
           
        }

        private void listFiles_DoubleClick(object sender, EventArgs e)
        {
            if (listFiles.SelectedItems.Count == 1)
            {
                var selectedItem = listFiles.SelectedItems[0];
                var node = (CloudFileSystemNode)selectedItem.Tag;
                if (node != null)
                {
                    currentDirectoryNode = node;
                    
                    if(currentDirectoryNode.Type == CloudFileSystemNodeTypeEnum.BUCKET || currentDirectoryNode.Type == CloudFileSystemNodeTypeEnum.DIRECTORY)
                    {
                        loadListFilesAtDirPath(currentDirectoryNode.AbsolutePath);
                    }
                    else if(currentDirectoryNode.Type == CloudFileSystemNodeTypeEnum.FILE)
                    {
                        // TODO
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButtonUp_Click(object sender, EventArgs e)
        {
            var path = CloudFileSystem.GetParentDirectoryPath(currentDirectoryNode.AbsolutePath);
            loadListFilesAtDirPath(path);
        }

        private void updatePathUi()
        {
            toolStripTextCloudPath.Text = currentDirectoryNode.AbsolutePath;
        }

        private void toolStripTextCloudPath_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void toolStripTextCloudPath_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var path = toolStripTextCloudPath.Text.Trim();
                var node = fs.FindNodeAtAbsolutePath(path);
                if (node != null)
                {
                    currentDirectoryNode = node;
                    loadListFilesAtDirPath(path);
                }
            }
        }

        private void downloadSelectedItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var items = listFiles.SelectedItems;
            if (items.Count > 0)
            {
                var d = new FolderBrowserDialog();
                d.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (d.ShowDialog() == DialogResult.OK)
                {
                    var downloadPath = d.SelectedPath;
                    var list = new List<string>();
                    foreach (ListViewItem item in items)
                    {
                        var node = (CloudFileSystemNode)item.Tag;
                        list.AddRange(fs.GetAllFilesAtDirPathAsList(node.AbsolutePath));
                    }

                    foreach(var filePath in list)
                    {
                        addItemToFileTransferList(filePath);
                    }
                }
            }
        }

        private void addItemToFileTransferList(string path)
        {
            listFileTransfer.Items.Add(path);
        }
    }
}
