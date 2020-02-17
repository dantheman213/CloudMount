namespace CloudMount
{
    partial class FrameConnect
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAWS = new System.Windows.Forms.TabPage();
            this.tabGCP = new System.Windows.Forms.TabPage();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textGCPProjectId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textGCPCredsFilepath = new System.Windows.Forms.TextBox();
            this.buttonBrowseGCPCreds = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabGCP.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAWS);
            this.tabControl.Controls.Add(this.tabGCP);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(705, 271);
            this.tabControl.TabIndex = 0;
            // 
            // tabAWS
            // 
            this.tabAWS.Location = new System.Drawing.Point(4, 29);
            this.tabAWS.Name = "tabAWS";
            this.tabAWS.Padding = new System.Windows.Forms.Padding(3);
            this.tabAWS.Size = new System.Drawing.Size(697, 216);
            this.tabAWS.TabIndex = 0;
            this.tabAWS.Text = "AWS";
            this.tabAWS.UseVisualStyleBackColor = true;
            // 
            // tabGCP
            // 
            this.tabGCP.Controls.Add(this.buttonBrowseGCPCreds);
            this.tabGCP.Controls.Add(this.textGCPCredsFilepath);
            this.tabGCP.Controls.Add(this.label2);
            this.tabGCP.Controls.Add(this.textGCPProjectId);
            this.tabGCP.Controls.Add(this.label1);
            this.tabGCP.Location = new System.Drawing.Point(4, 29);
            this.tabGCP.Name = "tabGCP";
            this.tabGCP.Padding = new System.Windows.Forms.Padding(3);
            this.tabGCP.Size = new System.Drawing.Size(697, 238);
            this.tabGCP.TabIndex = 1;
            this.tabGCP.Text = "GCP";
            this.tabGCP.UseVisualStyleBackColor = true;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(587, 298);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(126, 35);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project ID:";
            // 
            // textGCPProjectId
            // 
            this.textGCPProjectId.Location = new System.Drawing.Point(143, 19);
            this.textGCPProjectId.Name = "textGCPProjectId";
            this.textGCPProjectId.Size = new System.Drawing.Size(547, 26);
            this.textGCPProjectId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Credential File:";
            // 
            // textGCPCredsFilepath
            // 
            this.textGCPCredsFilepath.Location = new System.Drawing.Point(143, 51);
            this.textGCPCredsFilepath.Name = "textGCPCredsFilepath";
            this.textGCPCredsFilepath.ReadOnly = true;
            this.textGCPCredsFilepath.Size = new System.Drawing.Size(547, 26);
            this.textGCPCredsFilepath.TabIndex = 3;
            // 
            // buttonBrowseGCPCreds
            // 
            this.buttonBrowseGCPCreds.Location = new System.Drawing.Point(571, 84);
            this.buttonBrowseGCPCreds.Name = "buttonBrowseGCPCreds";
            this.buttonBrowseGCPCreds.Size = new System.Drawing.Size(118, 36);
            this.buttonBrowseGCPCreds.TabIndex = 4;
            this.buttonBrowseGCPCreds.Text = "Browse";
            this.buttonBrowseGCPCreds.UseVisualStyleBackColor = true;
            this.buttonBrowseGCPCreds.Click += new System.EventHandler(this.buttonBrowseGCPCreds_Click);
            // 
            // FrameConnect
            // 
            this.AcceptButton = this.buttonConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 345);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrameConnect";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to Cloud";
            this.tabControl.ResumeLayout(false);
            this.tabGCP.ResumeLayout(false);
            this.tabGCP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAWS;
        private System.Windows.Forms.TabPage tabGCP;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textGCPProjectId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textGCPCredsFilepath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBrowseGCPCreds;
    }
}