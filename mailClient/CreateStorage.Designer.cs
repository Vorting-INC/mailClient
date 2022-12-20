namespace mailClient
{
    partial class CreateStorage
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreateFileFolder = new System.Windows.Forms.Button();
            this.FileFolderName = new System.Windows.Forms.TextBox();
            this.FileFolderLokationLabel = new System.Windows.Forms.Label();
            this.FileFolderLokation = new System.Windows.Forms.TextBox();
            this.FileFolderNameLabel = new System.Windows.Forms.Label();
            this.OpenFileManager = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CreateFileFolder
            // 
            this.CreateFileFolder.Location = new System.Drawing.Point(405, 284);
            this.CreateFileFolder.Name = "CreateFileFolder";
            this.CreateFileFolder.Size = new System.Drawing.Size(120, 51);
            this.CreateFileFolder.TabIndex = 2;
            this.CreateFileFolder.Text = "Create a file folder";
            this.CreateFileFolder.UseVisualStyleBackColor = true;
            this.CreateFileFolder.Click += new System.EventHandler(this.CreateFileFolder_Click);
            // 
            // FileFolderName
            // 
            this.FileFolderName.Location = new System.Drawing.Point(143, 248);
            this.FileFolderName.Name = "FileFolderName";
            this.FileFolderName.Size = new System.Drawing.Size(383, 20);
            this.FileFolderName.TabIndex = 3;
            this.FileFolderName.TextChanged += new System.EventHandler(this.FileFolderName_TextChanged);
            // 
            // FileFolderLokationLabel
            // 
            this.FileFolderLokationLabel.AutoSize = true;
            this.FileFolderLokationLabel.Location = new System.Drawing.Point(140, 146);
            this.FileFolderLokationLabel.Name = "FileFolderLokationLabel";
            this.FileFolderLokationLabel.Size = new System.Drawing.Size(233, 13);
            this.FileFolderLokationLabel.TabIndex = 4;
            this.FileFolderLokationLabel.Text = "Enter system path to desired  lokation of folder !)";
            this.FileFolderLokationLabel.Click += new System.EventHandler(this.FileFolderLokationLabel_Click);
            // 
            // FileFolderLokation
            // 
            this.FileFolderLokation.Location = new System.Drawing.Point(143, 178);
            this.FileFolderLokation.Name = "FileFolderLokation";
            this.FileFolderLokation.Size = new System.Drawing.Size(382, 20);
            this.FileFolderLokation.TabIndex = 5;
            this.FileFolderLokation.TextChanged += new System.EventHandler(this.FileFolderLokation_TextChanged);
            // 
            // FileFolderNameLabel
            // 
            this.FileFolderNameLabel.AutoSize = true;
            this.FileFolderNameLabel.Location = new System.Drawing.Point(143, 216);
            this.FileFolderNameLabel.Name = "FileFolderNameLabel";
            this.FileFolderNameLabel.Size = new System.Drawing.Size(106, 13);
            this.FileFolderNameLabel.TabIndex = 6;
            this.FileFolderNameLabel.Text = "Enter file folder name";
            // 
            // OpenFileManager
            // 
            this.OpenFileManager.Location = new System.Drawing.Point(143, 284);
            this.OpenFileManager.Name = "OpenFileManager";
            this.OpenFileManager.Size = new System.Drawing.Size(138, 51);
            this.OpenFileManager.TabIndex = 7;
            this.OpenFileManager.Text = "Open file manager";
            this.OpenFileManager.UseVisualStyleBackColor = true;
            this.OpenFileManager.Click += new System.EventHandler(this.OpenFileManager_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "There is no local created storage on this machine you will need to create one to " +
    "recieve emails";
            // 
            // CreateStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenFileManager);
            this.Controls.Add(this.FileFolderNameLabel);
            this.Controls.Add(this.FileFolderLokation);
            this.Controls.Add(this.FileFolderLokationLabel);
            this.Controls.Add(this.FileFolderName);
            this.Controls.Add(this.CreateFileFolder);
            this.Name = "CreateStorage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateStorage";
            this.Load += new System.EventHandler(this.CreateStorage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button CreateFileFolder;
        private System.Windows.Forms.TextBox FileFolderName;
        private System.Windows.Forms.Label FileFolderLokationLabel;
        private System.Windows.Forms.TextBox FileFolderLokation;
        private System.Windows.Forms.Label FileFolderNameLabel;
        private System.Windows.Forms.Button OpenFileManager;
        private System.Windows.Forms.Label label1;
    }
}