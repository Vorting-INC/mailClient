namespace mailClient
{
    partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.RetrieveNewEmail = new System.Windows.Forms.Button();
            this.RetrievedFolders = new System.Windows.Forms.ListBox();
            this.RetrieveAllEmail = new System.Windows.Forms.Button();
            this.RetriveFolders = new System.Windows.Forms.Button();
            this.CreateStorageButton = new System.Windows.Forms.Button();
            this.SendAnEmail = new System.Windows.Forms.Button();
            this.EmailListView = new System.Windows.Forms.ListView();
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SeenButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.FlagButton = new System.Windows.Forms.Button();
            this.MoveEmailButton = new System.Windows.Forms.Button();
            this.SpecialSetting = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RetrieveNewEmail
            // 
            this.RetrieveNewEmail.Location = new System.Drawing.Point(12, 454);
            this.RetrieveNewEmail.Name = "RetrieveNewEmail";
            this.RetrieveNewEmail.Size = new System.Drawing.Size(113, 26);
            this.RetrieveNewEmail.TabIndex = 0;
            this.RetrieveNewEmail.Text = "Retrieve new emails";
            this.RetrieveNewEmail.UseVisualStyleBackColor = true;
            this.RetrieveNewEmail.Click += new System.EventHandler(this.Recieve_Click);
            // 
            // RetrievedFolders
            // 
            this.RetrievedFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetrievedFolders.FormattingEnabled = true;
            this.RetrievedFolders.ItemHeight = 25;
            this.RetrievedFolders.Location = new System.Drawing.Point(12, 138);
            this.RetrievedFolders.Name = "RetrievedFolders";
            this.RetrievedFolders.Size = new System.Drawing.Size(125, 304);
            this.RetrievedFolders.TabIndex = 2;
            this.RetrievedFolders.SelectedIndexChanged += new System.EventHandler(this.RetrievedFolders_SelectedIndexChanged);
            // 
            // RetrieveAllEmail
            // 
            this.RetrieveAllEmail.Location = new System.Drawing.Point(665, 681);
            this.RetrieveAllEmail.Name = "RetrieveAllEmail";
            this.RetrieveAllEmail.Size = new System.Drawing.Size(113, 26);
            this.RetrieveAllEmail.TabIndex = 3;
            this.RetrieveAllEmail.Text = "Retrieve All Email";
            this.RetrieveAllEmail.UseVisualStyleBackColor = true;
            this.RetrieveAllEmail.Click += new System.EventHandler(this.RetrieveAllEmail_Click);
            // 
            // RetriveFolders
            // 
            this.RetriveFolders.Location = new System.Drawing.Point(784, 681);
            this.RetriveFolders.Name = "RetriveFolders";
            this.RetriveFolders.Size = new System.Drawing.Size(114, 26);
            this.RetriveFolders.TabIndex = 4;
            this.RetriveFolders.Text = "Retrieve Folders";
            this.RetriveFolders.UseVisualStyleBackColor = true;
            this.RetriveFolders.Click += new System.EventHandler(this.RetriveFolders_Click);
            // 
            // CreateStorageButton
            // 
            this.CreateStorageButton.Location = new System.Drawing.Point(904, 681);
            this.CreateStorageButton.Name = "CreateStorageButton";
            this.CreateStorageButton.Size = new System.Drawing.Size(113, 26);
            this.CreateStorageButton.TabIndex = 5;
            this.CreateStorageButton.Text = "Create storage";
            this.CreateStorageButton.UseVisualStyleBackColor = true;
            this.CreateStorageButton.Click += new System.EventHandler(this.CreateStorageButton_Click);
            // 
            // SendAnEmail
            // 
            this.SendAnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendAnEmail.Location = new System.Drawing.Point(12, 631);
            this.SendAnEmail.Name = "SendAnEmail";
            this.SendAnEmail.Size = new System.Drawing.Size(113, 44);
            this.SendAnEmail.TabIndex = 6;
            this.SendAnEmail.Text = "Send an email";
            this.SendAnEmail.UseVisualStyleBackColor = true;
            this.SendAnEmail.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmailListView
            // 
            this.EmailListView.BackColor = System.Drawing.SystemColors.Control;
            this.EmailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.From,
            this.Subject,
            this.Date});
            this.EmailListView.HideSelection = false;
            this.EmailListView.Location = new System.Drawing.Point(143, 12);
            this.EmailListView.Name = "EmailListView";
            this.EmailListView.Size = new System.Drawing.Size(874, 663);
            this.EmailListView.SmallImageList = this.imageList1;
            this.EmailListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.EmailListView.TabIndex = 7;
            this.EmailListView.UseCompatibleStateImageBehavior = false;
            this.EmailListView.View = System.Windows.Forms.View.Details;
            this.EmailListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.EmailListView_ColumnClick);
            this.EmailListView.SelectedIndexChanged += new System.EventHandler(this.EmailListView_SelectedIndexChanged_1);
            this.EmailListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EmailListView_MouseClick);
            this.EmailListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.EmailListView_MouseDoubleClick);
            // 
            // From
            // 
            this.From.Text = "From";
            this.From.Width = 306;
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            this.Subject.Width = 436;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 124;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "sigmalogo.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(12, 486);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(113, 23);
            this.RefreshButton.TabIndex = 9;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // SeenButton
            // 
            this.SeenButton.Location = new System.Drawing.Point(12, 602);
            this.SeenButton.Name = "SeenButton";
            this.SeenButton.Size = new System.Drawing.Size(113, 23);
            this.SeenButton.TabIndex = 10;
            this.SeenButton.Text = "Seen/Unseen";
            this.SeenButton.UseVisualStyleBackColor = true;
            this.SeenButton.Click += new System.EventHandler(this.SeenButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 515);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(113, 23);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // FlagButton
            // 
            this.FlagButton.Location = new System.Drawing.Point(12, 544);
            this.FlagButton.Name = "FlagButton";
            this.FlagButton.Size = new System.Drawing.Size(113, 23);
            this.FlagButton.TabIndex = 12;
            this.FlagButton.Text = "Favorite";
            this.FlagButton.UseVisualStyleBackColor = true;
            this.FlagButton.Click += new System.EventHandler(this.FlagButton_Click);
            // 
            // MoveEmailButton
            // 
            this.MoveEmailButton.Location = new System.Drawing.Point(12, 573);
            this.MoveEmailButton.Name = "MoveEmailButton";
            this.MoveEmailButton.Size = new System.Drawing.Size(113, 23);
            this.MoveEmailButton.TabIndex = 13;
            this.MoveEmailButton.Text = "Archive email";
            this.MoveEmailButton.UseVisualStyleBackColor = true;
            this.MoveEmailButton.Click += new System.EventHandler(this.MoveEmailButton_Click);
            // 
            // SpecialSetting
            // 
            this.SpecialSetting.AutoSize = true;
            this.SpecialSetting.Location = new System.Drawing.Point(580, 688);
            this.SpecialSetting.Name = "SpecialSetting";
            this.SpecialSetting.Size = new System.Drawing.Size(79, 13);
            this.SpecialSetting.TabIndex = 14;
            this.SpecialSetting.Text = "Speciel setting:";
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(27, 702);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 15;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1020, 737);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.SpecialSetting);
            this.Controls.Add(this.MoveEmailButton);
            this.Controls.Add(this.FlagButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SeenButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EmailListView);
            this.Controls.Add(this.SendAnEmail);
            this.Controls.Add(this.CreateStorageButton);
            this.Controls.Add(this.RetriveFolders);
            this.Controls.Add(this.RetrieveAllEmail);
            this.Controls.Add(this.RetrievedFolders);
            this.Controls.Add(this.RetrieveNewEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SigmaMail";
            this.Load += new System.EventHandler(this.Interface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RetrieveNewEmail;
        private System.Windows.Forms.ListBox RetrievedFolders;
        private System.Windows.Forms.Button RetrieveAllEmail;
        private System.Windows.Forms.Button RetriveFolders;
        private System.Windows.Forms.Button CreateStorageButton;
        private System.Windows.Forms.Button SendAnEmail;
        private System.Windows.Forms.ListView EmailListView;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button SeenButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button FlagButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button MoveEmailButton;
        private System.Windows.Forms.Label SpecialSetting;
        private System.Windows.Forms.Button SettingsButton;
    }
}