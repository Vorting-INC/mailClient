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
            this.Recieve = new System.Windows.Forms.Button();
            this.RecievedEmails = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Recieve
            // 
            this.Recieve.Location = new System.Drawing.Point(220, 368);
            this.Recieve.Name = "Recieve";
            this.Recieve.Size = new System.Drawing.Size(75, 23);
            this.Recieve.TabIndex = 0;
            this.Recieve.Text = "Recieve";
            this.Recieve.UseVisualStyleBackColor = true;
            this.Recieve.Click += new System.EventHandler(this.Recieve_Click);
            // 
            // RecievedEmails
            // 
            this.RecievedEmails.FormattingEnabled = true;
            this.RecievedEmails.Location = new System.Drawing.Point(16, 22);
            this.RecievedEmails.Name = "RecievedEmails";
            this.RecievedEmails.Size = new System.Drawing.Size(204, 394);
            this.RecievedEmails.TabIndex = 1;
            this.RecievedEmails.SelectedIndexChanged += new System.EventHandler(this.RecievedEmails_SelectedIndexChanged);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RecievedEmails);
            this.Controls.Add(this.Recieve);
            this.Name = "Interface";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Recieve;
        private System.Windows.Forms.ListBox RecievedEmails;
    }
}