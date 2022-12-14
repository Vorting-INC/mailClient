namespace mailClient
{
    partial class SendingEmail
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
            this.ToLabel = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.BodyLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.BodyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.CCTextBox = new System.Windows.Forms.TextBox();
            this.CClabel = new System.Windows.Forms.Label();
            this.AttachmentButton = new System.Windows.Forms.Button();
            this.AttachmentTextBox = new System.Windows.Forms.TextBox();
            this.AttachmentLabel = new System.Windows.Forms.Label();
            this.SaveTheEmail = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ContactComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.Location = new System.Drawing.Point(447, 43);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(49, 17);
            this.ToLabel.TabIndex = 0;
            this.ToLabel.Text = "Name:";
            this.ToLabel.Click += new System.EventHandler(this.ToLabel_Click);
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLabel.Location = new System.Drawing.Point(11, 105);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(59, 17);
            this.SubjectLabel.TabIndex = 1;
            this.SubjectLabel.Text = "Subject:";
            // 
            // BodyLabel
            // 
            this.BodyLabel.AutoSize = true;
            this.BodyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodyLabel.Location = new System.Drawing.Point(11, 141);
            this.BodyLabel.Name = "BodyLabel";
            this.BodyLabel.Size = new System.Drawing.Size(44, 17);
            this.BodyLabel.TabIndex = 2;
            this.BodyLabel.Text = "Body:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(99, 42);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(342, 20);
            this.EmailTextBox.TabIndex = 3;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.v);
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Location = new System.Drawing.Point(99, 105);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(647, 20);
            this.SubjectTextBox.TabIndex = 4;
            // 
            // BodyRichTextBox
            // 
            this.BodyRichTextBox.Location = new System.Drawing.Point(99, 141);
            this.BodyRichTextBox.Name = "BodyRichTextBox";
            this.BodyRichTextBox.Size = new System.Drawing.Size(647, 314);
            this.BodyRichTextBox.TabIndex = 5;
            this.BodyRichTextBox.Text = "";
            this.BodyRichTextBox.TextChanged += new System.EventHandler(this.BodyRichTextBox_TextChanged);
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SendButton.Location = new System.Drawing.Point(99, 547);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(130, 49);
            this.SendButton.TabIndex = 6;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // CCTextBox
            // 
            this.CCTextBox.Location = new System.Drawing.Point(99, 70);
            this.CCTextBox.Name = "CCTextBox";
            this.CCTextBox.Size = new System.Drawing.Size(647, 20);
            this.CCTextBox.TabIndex = 7;
            // 
            // CClabel
            // 
            this.CClabel.AutoSize = true;
            this.CClabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CClabel.Location = new System.Drawing.Point(11, 70);
            this.CClabel.Name = "CClabel";
            this.CClabel.Size = new System.Drawing.Size(30, 17);
            this.CClabel.TabIndex = 8;
            this.CClabel.Text = "CC:";
            // 
            // AttachmentButton
            // 
            this.AttachmentButton.Location = new System.Drawing.Point(648, 473);
            this.AttachmentButton.Name = "AttachmentButton";
            this.AttachmentButton.Size = new System.Drawing.Size(98, 21);
            this.AttachmentButton.TabIndex = 9;
            this.AttachmentButton.Text = "Attachment";
            this.AttachmentButton.UseVisualStyleBackColor = true;
            this.AttachmentButton.Click += new System.EventHandler(this.AttachmentButton_Click);
            // 
            // AttachmentTextBox
            // 
            this.AttachmentTextBox.Location = new System.Drawing.Point(99, 474);
            this.AttachmentTextBox.Name = "AttachmentTextBox";
            this.AttachmentTextBox.Size = new System.Drawing.Size(543, 20);
            this.AttachmentTextBox.TabIndex = 10;
            this.AttachmentTextBox.TextChanged += new System.EventHandler(this.AttachmentTextBox_TextChanged);
            // 
            // AttachmentLabel
            // 
            this.AttachmentLabel.AutoSize = true;
            this.AttachmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttachmentLabel.Location = new System.Drawing.Point(11, 474);
            this.AttachmentLabel.Name = "AttachmentLabel";
            this.AttachmentLabel.Size = new System.Drawing.Size(83, 17);
            this.AttachmentLabel.TabIndex = 11;
            this.AttachmentLabel.Text = "Attachment:";
            // 
            // SaveTheEmail
            // 
            this.SaveTheEmail.AutoSize = true;
            this.SaveTheEmail.Checked = true;
            this.SaveTheEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveTheEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveTheEmail.Location = new System.Drawing.Point(99, 511);
            this.SaveTheEmail.Name = "SaveTheEmail";
            this.SaveTheEmail.Size = new System.Drawing.Size(171, 21);
            this.SaveTheEmail.TabIndex = 13;
            this.SaveTheEmail.Text = "Save the email to send";
            this.SaveTheEmail.UseVisualStyleBackColor = true;
            this.SaveTheEmail.CheckedChanged += new System.EventHandler(this.SaveTheEmail_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(277, 514);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Snap Mail";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // ContactComboBox
            // 
            this.ContactComboBox.FormattingEnabled = true;
            this.ContactComboBox.Location = new System.Drawing.Point(99, 16);
            this.ContactComboBox.Name = "ContactComboBox";
            this.ContactComboBox.Size = new System.Drawing.Size(647, 21);
            this.ContactComboBox.TabIndex = 15;
            this.ContactComboBox.SelectedIndexChanged += new System.EventHandler(this.ContactBox_SelectedIndexChanged);
            this.ContactComboBox.Click += new System.EventHandler(this.ContactComboBox_Click);
            this.ContactComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContactComboBox_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Contact list:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(502, 43);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(239, 20);
            this.NameBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Email:";
            // 
            // SendingEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContactComboBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.SaveTheEmail);
            this.Controls.Add(this.AttachmentLabel);
            this.Controls.Add(this.AttachmentTextBox);
            this.Controls.Add(this.AttachmentButton);
            this.Controls.Add(this.CClabel);
            this.Controls.Add(this.CCTextBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.BodyRichTextBox);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.BodyLabel);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.ToLabel);
            this.Name = "SendingEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email editor";
            this.Load += new System.EventHandler(this.Sending_an_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Label BodyLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.RichTextBox BodyRichTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox CCTextBox;
        private System.Windows.Forms.Label CClabel;
        private System.Windows.Forms.Button AttachmentButton;
        private System.Windows.Forms.TextBox AttachmentTextBox;
        private System.Windows.Forms.Label AttachmentLabel;
        private System.Windows.Forms.CheckBox SaveTheEmail;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox ContactComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
    }
}