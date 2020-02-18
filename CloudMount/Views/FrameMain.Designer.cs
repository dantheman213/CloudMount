namespace CloudMount
{
    partial class FrameMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToGCPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listFiles = new System.Windows.Forms.ListView();
            this.imageCollectionIcons = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextCloudPath = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.cloudToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1757, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cloudToolStripMenuItem
            // 
            this.cloudToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToGCPToolStripMenuItem});
            this.cloudToolStripMenuItem.Name = "cloudToolStripMenuItem";
            this.cloudToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.cloudToolStripMenuItem.Text = "Cloud";
            // 
            // connectToGCPToolStripMenuItem
            // 
            this.connectToGCPToolStripMenuItem.Name = "connectToGCPToolStripMenuItem";
            this.connectToGCPToolStripMenuItem.Size = new System.Drawing.Size(235, 30);
            this.connectToGCPToolStripMenuItem.Text = "Connect to Cloud";
            this.connectToGCPToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // listFiles
            // 
            this.listFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFiles.ForeColor = System.Drawing.Color.Black;
            this.listFiles.HideSelection = false;
            this.listFiles.LargeImageList = this.imageCollectionIcons;
            this.listFiles.Location = new System.Drawing.Point(0, 64);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(1757, 1027);
            this.listFiles.TabIndex = 1;
            this.listFiles.UseCompatibleStateImageBehavior = false;
            this.listFiles.DoubleClick += new System.EventHandler(this.listFiles_DoubleClick);
            // 
            // imageCollectionIcons
            // 
            this.imageCollectionIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageCollectionIcons.ImageStream")));
            this.imageCollectionIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageCollectionIcons.Images.SetKeyName(0, "folder.png");
            this.imageCollectionIcons.Images.SetKeyName(1, "file.png");
            // 
            // toolStrip
            // 
            this.toolStrip.AllowMerge = false;
            this.toolStrip.CanOverflow = false;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonUp,
            this.toolStripTextCloudPath});
            this.toolStrip.Location = new System.Drawing.Point(0, 33);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(1757, 31);
            this.toolStrip.TabIndex = 2;
            // 
            // toolStripButtonUp
            // 
            this.toolStripButtonUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUp.Image")));
            this.toolStripButtonUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUp.Name = "toolStripButtonUp";
            this.toolStripButtonUp.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonUp.Text = "Go Up One Directory Level";
            this.toolStripButtonUp.Click += new System.EventHandler(this.toolStripButtonUp_Click);
            // 
            // toolStripTextCloudPath
            // 
            this.toolStripTextCloudPath.Name = "toolStripTextCloudPath";
            this.toolStripTextCloudPath.Size = new System.Drawing.Size(600, 31);
            this.toolStripTextCloudPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextCloudPath_KeyPress);
            this.toolStripTextCloudPath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextCloudPath_KeyUp);
            // 
            // FrameMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1757, 1091);
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrameMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CloudMount";
            this.Load += new System.EventHandler(this.FrameMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToGCPToolStripMenuItem;
        private System.Windows.Forms.ListView listFiles;
        private System.Windows.Forms.ImageList imageCollectionIcons;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonUp;
        private System.Windows.Forms.ToolStripTextBox toolStripTextCloudPath;
    }
}

