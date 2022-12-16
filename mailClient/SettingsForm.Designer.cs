namespace mailClient
{
    partial class SettingsForm
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
            this.BadWordsBox = new System.Windows.Forms.ListBox();
            this.SpamWordsBox = new System.Windows.Forms.ListBox();
            this.InpuxBox = new System.Windows.Forms.TextBox();
            this.AddSpamWordButton = new System.Windows.Forms.Button();
            this.RemoveSpamWordButton = new System.Windows.Forms.Button();
            this.RemoveBadWordButton = new System.Windows.Forms.Button();
            this.AddBadWordButton = new System.Windows.Forms.Button();
            this.SaveSpamWordButton = new System.Windows.Forms.Button();
            this.SaveBadWordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BadWordsBox
            // 
            this.BadWordsBox.FormattingEnabled = true;
            this.BadWordsBox.Location = new System.Drawing.Point(633, 12);
            this.BadWordsBox.Name = "BadWordsBox";
            this.BadWordsBox.Size = new System.Drawing.Size(120, 381);
            this.BadWordsBox.TabIndex = 0;
            // 
            // SpamWordsBox
            // 
            this.SpamWordsBox.FormattingEnabled = true;
            this.SpamWordsBox.Location = new System.Drawing.Point(507, 12);
            this.SpamWordsBox.Name = "SpamWordsBox";
            this.SpamWordsBox.Size = new System.Drawing.Size(120, 381);
            this.SpamWordsBox.TabIndex = 1;
            // 
            // InpuxBox
            // 
            this.InpuxBox.Location = new System.Drawing.Point(507, 402);
            this.InpuxBox.Name = "InpuxBox";
            this.InpuxBox.Size = new System.Drawing.Size(246, 20);
            this.InpuxBox.TabIndex = 2;
            // 
            // AddSpamWordButton
            // 
            this.AddSpamWordButton.Location = new System.Drawing.Point(507, 428);
            this.AddSpamWordButton.Name = "AddSpamWordButton";
            this.AddSpamWordButton.Size = new System.Drawing.Size(119, 23);
            this.AddSpamWordButton.TabIndex = 3;
            this.AddSpamWordButton.Text = "Add";
            this.AddSpamWordButton.UseVisualStyleBackColor = true;
            this.AddSpamWordButton.Click += new System.EventHandler(this.AddSpamWordButton_Click);
            // 
            // RemoveSpamWordButton
            // 
            this.RemoveSpamWordButton.Location = new System.Drawing.Point(508, 457);
            this.RemoveSpamWordButton.Name = "RemoveSpamWordButton";
            this.RemoveSpamWordButton.Size = new System.Drawing.Size(119, 23);
            this.RemoveSpamWordButton.TabIndex = 4;
            this.RemoveSpamWordButton.Text = "Remove";
            this.RemoveSpamWordButton.UseVisualStyleBackColor = true;
            this.RemoveSpamWordButton.Click += new System.EventHandler(this.RemoveSpamWordButton_Click);
            // 
            // RemoveBadWordButton
            // 
            this.RemoveBadWordButton.Location = new System.Drawing.Point(635, 457);
            this.RemoveBadWordButton.Name = "RemoveBadWordButton";
            this.RemoveBadWordButton.Size = new System.Drawing.Size(119, 23);
            this.RemoveBadWordButton.TabIndex = 6;
            this.RemoveBadWordButton.Text = "Remove";
            this.RemoveBadWordButton.UseVisualStyleBackColor = true;
            this.RemoveBadWordButton.Click += new System.EventHandler(this.RemoveBadWordButton_Click);
            // 
            // AddBadWordButton
            // 
            this.AddBadWordButton.Location = new System.Drawing.Point(634, 428);
            this.AddBadWordButton.Name = "AddBadWordButton";
            this.AddBadWordButton.Size = new System.Drawing.Size(119, 23);
            this.AddBadWordButton.TabIndex = 5;
            this.AddBadWordButton.Text = "Add";
            this.AddBadWordButton.UseVisualStyleBackColor = true;
            this.AddBadWordButton.Click += new System.EventHandler(this.AddBadWordButton_Click);
            // 
            // SaveSpamWordButton
            // 
            this.SaveSpamWordButton.Location = new System.Drawing.Point(512, 486);
            this.SaveSpamWordButton.Name = "SaveSpamWordButton";
            this.SaveSpamWordButton.Size = new System.Drawing.Size(115, 25);
            this.SaveSpamWordButton.TabIndex = 7;
            this.SaveSpamWordButton.Text = "Save";
            this.SaveSpamWordButton.UseVisualStyleBackColor = true;
            this.SaveSpamWordButton.Click += new System.EventHandler(this.SaveSpamWordButton_Click);
            // 
            // SaveBadWordButton
            // 
            this.SaveBadWordButton.Location = new System.Drawing.Point(638, 486);
            this.SaveBadWordButton.Name = "SaveBadWordButton";
            this.SaveBadWordButton.Size = new System.Drawing.Size(115, 25);
            this.SaveBadWordButton.TabIndex = 8;
            this.SaveBadWordButton.Text = "Save";
            this.SaveBadWordButton.UseVisualStyleBackColor = true;
            this.SaveBadWordButton.Click += new System.EventHandler(this.SaveBadWordButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.SaveBadWordButton);
            this.Controls.Add(this.SaveSpamWordButton);
            this.Controls.Add(this.RemoveBadWordButton);
            this.Controls.Add(this.AddBadWordButton);
            this.Controls.Add(this.RemoveSpamWordButton);
            this.Controls.Add(this.AddSpamWordButton);
            this.Controls.Add(this.InpuxBox);
            this.Controls.Add(this.SpamWordsBox);
            this.Controls.Add(this.BadWordsBox);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BadWordsBox;
        private System.Windows.Forms.ListBox SpamWordsBox;
        private System.Windows.Forms.TextBox InpuxBox;
        private System.Windows.Forms.Button AddSpamWordButton;
        private System.Windows.Forms.Button RemoveSpamWordButton;
        private System.Windows.Forms.Button RemoveBadWordButton;
        private System.Windows.Forms.Button AddBadWordButton;
        private System.Windows.Forms.Button SaveSpamWordButton;
        private System.Windows.Forms.Button SaveBadWordButton;
    }
}