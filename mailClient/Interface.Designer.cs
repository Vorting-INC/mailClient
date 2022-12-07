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
            this.RetrieveNewEmail = new System.Windows.Forms.Button();
            this.RecievedEmails = new System.Windows.Forms.ListBox();
            this.RetrievedFolders = new System.Windows.Forms.ListBox();
            this.RetrieveAllEmail = new System.Windows.Forms.Button();
            this.RetriveFolders = new System.Windows.Forms.Button();
            this.CreateStorageButton = new System.Windows.Forms.Button();
            this.SendAnEmail = new System.Windows.Forms.Button();
            this.EmailListView = new System.Windows.Forms.ListView();
            this.SenderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // RetrieveNewEmail
            // 
            this.RetrieveNewEmail.Location = new System.Drawing.Point(25, 575);
            this.RetrieveNewEmail.Name = "RetrieveNewEmail";
            this.RetrieveNewEmail.Size = new System.Drawing.Size(113, 26);
            this.RetrieveNewEmail.TabIndex = 0;
            this.RetrieveNewEmail.Text = "Retrieve new emails";
            this.RetrieveNewEmail.UseVisualStyleBackColor = true;
            this.RetrieveNewEmail.Click += new System.EventHandler(this.Recieve_Click);
            // 
            // RecievedEmails
            // 
            this.RecievedEmails.FormattingEnabled = true;
            this.RecievedEmails.Location = new System.Drawing.Point(781, 12);
            this.RecievedEmails.Name = "RecievedEmails";
            this.RecievedEmails.Size = new System.Drawing.Size(312, 654);
            this.RecievedEmails.TabIndex = 1;
            this.RecievedEmails.SelectedIndexChanged += new System.EventHandler(this.RecievedEmails_SelectedIndexChanged);
            // 
            // RetrievedFolders
            // 
            this.RetrievedFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetrievedFolders.FormattingEnabled = true;
            this.RetrievedFolders.ItemHeight = 25;
            this.RetrievedFolders.Location = new System.Drawing.Point(12, 12);
            this.RetrievedFolders.Name = "RetrievedFolders";
            this.RetrievedFolders.Size = new System.Drawing.Size(125, 454);
            this.RetrievedFolders.TabIndex = 2;
            this.RetrievedFolders.SelectedIndexChanged += new System.EventHandler(this.RetrievedFolders_SelectedIndexChanged);
            // 
            // RetrieveAllEmail
            // 
            this.RetrieveAllEmail.Location = new System.Drawing.Point(25, 543);
            this.RetrieveAllEmail.Name = "RetrieveAllEmail";
            this.RetrieveAllEmail.Size = new System.Drawing.Size(113, 26);
            this.RetrieveAllEmail.TabIndex = 3;
            this.RetrieveAllEmail.Text = "Retrieve All Email";
            this.RetrieveAllEmail.UseVisualStyleBackColor = true;
            this.RetrieveAllEmail.Click += new System.EventHandler(this.RetrieveAllEmail_Click);
            // 
            // RetriveFolders
            // 
            this.RetriveFolders.Location = new System.Drawing.Point(24, 511);
            this.RetriveFolders.Name = "RetriveFolders";
            this.RetriveFolders.Size = new System.Drawing.Size(114, 26);
            this.RetriveFolders.TabIndex = 4;
            this.RetriveFolders.Text = "Retrieve Folders";
            this.RetriveFolders.UseVisualStyleBackColor = true;
            this.RetriveFolders.Click += new System.EventHandler(this.RetriveFolders_Click);
            // 
            // CreateStorageButton
            // 
            this.CreateStorageButton.Location = new System.Drawing.Point(24, 479);
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
            this.SendAnEmail.Location = new System.Drawing.Point(25, 622);
            this.SendAnEmail.Name = "SendAnEmail";
            this.SendAnEmail.Size = new System.Drawing.Size(113, 44);
            this.SendAnEmail.TabIndex = 6;
            this.SendAnEmail.Text = "Send an email";
            this.SendAnEmail.UseVisualStyleBackColor = true;
            this.SendAnEmail.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmailListView
            // 
            this.EmailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SenderColumn,
            this.SubjectColumn,
            this.DateColumn});
            this.EmailListView.HideSelection = false;
            this.EmailListView.Location = new System.Drawing.Point(144, 11);
            this.EmailListView.Name = "EmailListView";
            this.EmailListView.Size = new System.Drawing.Size(600, 600);
            this.EmailListView.TabIndex = 8;
            this.EmailListView.UseCompatibleStateImageBehavior = false;
            this.EmailListView.View = System.Windows.Forms.View.Details;
            this.EmailListView.SelectedIndexChanged += new System.EventHandler(this.EmailListView_SelectedIndexChanged);
            // 
            // SenderColumn
            // 
            this.SenderColumn.Text = "Sender";
            this.SenderColumn.Width = 200;
            // 
            // SubjectColumn
            // 
            this.SubjectColumn.Text = "Subject";
            this.SubjectColumn.Width = 300;
            // 
            // DateColumn
            // 
            this.DateColumn.Text = "Date";
            this.DateColumn.Width = 100;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 710);
            this.Controls.Add(this.EmailListView);
            this.Controls.Add(this.SendAnEmail);
            this.Controls.Add(this.CreateStorageButton);
            this.Controls.Add(this.RetriveFolders);
            this.Controls.Add(this.RetrieveAllEmail);
            this.Controls.Add(this.RetrievedFolders);
            this.Controls.Add(this.RecievedEmails);
            this.Controls.Add(this.RetrieveNewEmail);
            this.Name = "Interface";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RetrieveNewEmail;
        private System.Windows.Forms.ListBox RecievedEmails;
        private System.Windows.Forms.ListBox RetrievedFolders;
        private System.Windows.Forms.Button RetrieveAllEmail;
        private System.Windows.Forms.Button RetriveFolders;
        private System.Windows.Forms.Button CreateStorageButton;
        private System.Windows.Forms.Button SendAnEmail;
        private System.Windows.Forms.ListView EmailListView;
        private System.Windows.Forms.ColumnHeader SenderColumn;
        private System.Windows.Forms.ColumnHeader SubjectColumn;
        private System.Windows.Forms.ColumnHeader DateColumn;
    }
}