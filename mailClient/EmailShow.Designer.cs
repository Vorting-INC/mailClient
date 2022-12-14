namespace mailClient
{
    partial class EmailShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailShow));
            this.FromBox = new System.Windows.Forms.TextBox();
            this.SubjectBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BodyRichBox = new System.Windows.Forms.RichTextBox();
            this.CcBox = new System.Windows.Forms.TextBox();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.AttachmentBox = new System.Windows.Forms.TextBox();
            this.OpenAttachment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ReplyButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.SaveContactButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FromBox
            // 
            this.FromBox.Location = new System.Drawing.Point(87, 68);
            this.FromBox.Name = "FromBox";
            this.FromBox.Size = new System.Drawing.Size(392, 20);
            this.FromBox.TabIndex = 0;
            this.FromBox.TextChanged += new System.EventHandler(this.FromBox_TextChanged);
            // 
            // SubjectBox
            // 
            this.SubjectBox.Location = new System.Drawing.Point(87, 94);
            this.SubjectBox.Name = "SubjectBox";
            this.SubjectBox.Size = new System.Drawing.Size(777, 20);
            this.SubjectBox.TabIndex = 1;
            this.SubjectBox.TextChanged += new System.EventHandler(this.SubjectBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(88, 533);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 244);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BodyRichBox
            // 
            this.BodyRichBox.Location = new System.Drawing.Point(88, 146);
            this.BodyRichBox.Name = "BodyRichBox";
            this.BodyRichBox.Size = new System.Drawing.Size(776, 355);
            this.BodyRichBox.TabIndex = 3;
            this.BodyRichBox.Text = "";
            this.BodyRichBox.TextChanged += new System.EventHandler(this.BodyRichBox_TextChanged);
            // 
            // CcBox
            // 
            this.CcBox.Location = new System.Drawing.Point(88, 120);
            this.CcBox.Name = "CcBox";
            this.CcBox.Size = new System.Drawing.Size(391, 20);
            this.CcBox.TabIndex = 4;
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(532, 68);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(158, 20);
            this.DateBox.TabIndex = 5;
            // 
            // AttachmentBox
            // 
            this.AttachmentBox.Location = new System.Drawing.Point(88, 507);
            this.AttachmentBox.Name = "AttachmentBox";
            this.AttachmentBox.Size = new System.Drawing.Size(506, 20);
            this.AttachmentBox.TabIndex = 6;
            // 
            // OpenAttachment
            // 
            this.OpenAttachment.Location = new System.Drawing.Point(600, 507);
            this.OpenAttachment.Name = "OpenAttachment";
            this.OpenAttachment.Size = new System.Drawing.Size(75, 23);
            this.OpenAttachment.TabIndex = 7;
            this.OpenAttachment.Text = "Open file";
            this.OpenAttachment.UseVisualStyleBackColor = true;
            this.OpenAttachment.Click += new System.EventHandler(this.OpenAttachment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "From";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Body";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Attachment";
            // 
            // ReplyButton
            // 
            this.ReplyButton.Location = new System.Drawing.Point(87, 27);
            this.ReplyButton.Name = "ReplyButton";
            this.ReplyButton.Size = new System.Drawing.Size(75, 23);
            this.ReplyButton.TabIndex = 14;
            this.ReplyButton.Text = "Reply";
            this.ReplyButton.UseVisualStyleBackColor = true;
            this.ReplyButton.Click += new System.EventHandler(this.ReplyButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.Location = new System.Drawing.Point(168, 27);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(75, 23);
            this.ForwardButton.TabIndex = 15;
            this.ForwardButton.Text = "Forward";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // SaveContactButton
            // 
            this.SaveContactButton.Location = new System.Drawing.Point(249, 27);
            this.SaveContactButton.Name = "SaveContactButton";
            this.SaveContactButton.Size = new System.Drawing.Size(96, 23);
            this.SaveContactButton.TabIndex = 16;
            this.SaveContactButton.Text = "Save Contact";
            this.SaveContactButton.UseVisualStyleBackColor = true;
            this.SaveContactButton.Click += new System.EventHandler(this.SaveContactButton_Click);
            // 
            // EmailShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 791);
            this.Controls.Add(this.SaveContactButton);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.ReplyButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenAttachment);
            this.Controls.Add(this.AttachmentBox);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.CcBox);
            this.Controls.Add(this.BodyRichBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SubjectBox);
            this.Controls.Add(this.FromBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmailShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmailShow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FromBox;
        private System.Windows.Forms.TextBox SubjectBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox BodyRichBox;
        private System.Windows.Forms.TextBox CcBox;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.TextBox AttachmentBox;
        private System.Windows.Forms.Button OpenAttachment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ReplyButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button SaveContactButton;
    }
}