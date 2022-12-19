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
            this.SpamCheckBox = new System.Windows.Forms.CheckBox();
            this.BadWordActive = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BadWordsBox
            // 
            this.BadWordsBox.FormattingEnabled = true;
            this.BadWordsBox.Location = new System.Drawing.Point(184, 37);
            this.BadWordsBox.Name = "BadWordsBox";
            this.BadWordsBox.Size = new System.Drawing.Size(149, 381);
            this.BadWordsBox.TabIndex = 0;
            // 
            // SpamWordsBox
            // 
            this.SpamWordsBox.FormattingEnabled = true;
            this.SpamWordsBox.Location = new System.Drawing.Point(29, 37);
            this.SpamWordsBox.Name = "SpamWordsBox";
            this.SpamWordsBox.Size = new System.Drawing.Size(149, 381);
            this.SpamWordsBox.TabIndex = 1;
            // 
            // InpuxBox
            // 
            this.InpuxBox.Location = new System.Drawing.Point(29, 427);
            this.InpuxBox.Name = "InpuxBox";
            this.InpuxBox.Size = new System.Drawing.Size(301, 20);
            this.InpuxBox.TabIndex = 2;
            // 
            // AddSpamWordButton
            // 
            this.AddSpamWordButton.Location = new System.Drawing.Point(29, 453);
            this.AddSpamWordButton.Name = "AddSpamWordButton";
            this.AddSpamWordButton.Size = new System.Drawing.Size(149, 26);
            this.AddSpamWordButton.TabIndex = 3;
            this.AddSpamWordButton.Text = "Add";
            this.AddSpamWordButton.UseVisualStyleBackColor = true;
            this.AddSpamWordButton.Click += new System.EventHandler(this.AddSpamWordButton_Click);
            // 
            // RemoveSpamWordButton
            // 
            this.RemoveSpamWordButton.Location = new System.Drawing.Point(29, 482);
            this.RemoveSpamWordButton.Name = "RemoveSpamWordButton";
            this.RemoveSpamWordButton.Size = new System.Drawing.Size(149, 26);
            this.RemoveSpamWordButton.TabIndex = 4;
            this.RemoveSpamWordButton.Text = "Remove";
            this.RemoveSpamWordButton.UseVisualStyleBackColor = true;
            this.RemoveSpamWordButton.Click += new System.EventHandler(this.RemoveSpamWordButton_Click);
            // 
            // RemoveBadWordButton
            // 
            this.RemoveBadWordButton.Location = new System.Drawing.Point(181, 482);
            this.RemoveBadWordButton.Name = "RemoveBadWordButton";
            this.RemoveBadWordButton.Size = new System.Drawing.Size(149, 26);
            this.RemoveBadWordButton.TabIndex = 6;
            this.RemoveBadWordButton.Text = "Remove";
            this.RemoveBadWordButton.UseVisualStyleBackColor = true;
            this.RemoveBadWordButton.Click += new System.EventHandler(this.RemoveBadWordButton_Click);
            // 
            // AddBadWordButton
            // 
            this.AddBadWordButton.Location = new System.Drawing.Point(181, 453);
            this.AddBadWordButton.Name = "AddBadWordButton";
            this.AddBadWordButton.Size = new System.Drawing.Size(149, 26);
            this.AddBadWordButton.TabIndex = 5;
            this.AddBadWordButton.Text = "Add";
            this.AddBadWordButton.UseVisualStyleBackColor = true;
            this.AddBadWordButton.Click += new System.EventHandler(this.AddBadWordButton_Click);
            // 
            // SaveSpamWordButton
            // 
            this.SaveSpamWordButton.Location = new System.Drawing.Point(29, 511);
            this.SaveSpamWordButton.Name = "SaveSpamWordButton";
            this.SaveSpamWordButton.Size = new System.Drawing.Size(149, 26);
            this.SaveSpamWordButton.TabIndex = 7;
            this.SaveSpamWordButton.Text = "Save";
            this.SaveSpamWordButton.UseVisualStyleBackColor = true;
            this.SaveSpamWordButton.Click += new System.EventHandler(this.SaveSpamWordButton_Click);
            // 
            // SaveBadWordButton
            // 
            this.SaveBadWordButton.Location = new System.Drawing.Point(181, 511);
            this.SaveBadWordButton.Name = "SaveBadWordButton";
            this.SaveBadWordButton.Size = new System.Drawing.Size(149, 26);
            this.SaveBadWordButton.TabIndex = 8;
            this.SaveBadWordButton.Text = "Save";
            this.SaveBadWordButton.UseVisualStyleBackColor = true;
            this.SaveBadWordButton.Click += new System.EventHandler(this.SaveBadWordButton_Click);
            // 
            // SpamCheckBox
            // 
            this.SpamCheckBox.AutoSize = true;
            this.SpamCheckBox.Location = new System.Drawing.Point(29, 543);
            this.SpamCheckBox.Name = "SpamCheckBox";
            this.SpamCheckBox.Size = new System.Drawing.Size(107, 17);
            this.SpamCheckBox.TabIndex = 9;
            this.SpamCheckBox.Text = "Spam filter active";
            this.SpamCheckBox.UseVisualStyleBackColor = true;
            this.SpamCheckBox.CheckedChanged += new System.EventHandler(this.SpamCheckBox_CheckedChanged);
            // 
            // BadWordActive
            // 
            this.BadWordActive.AutoSize = true;
            this.BadWordActive.Location = new System.Drawing.Point(181, 543);
            this.BadWordActive.Name = "BadWordActive";
            this.BadWordActive.Size = new System.Drawing.Size(122, 17);
            this.BadWordActive.TabIndex = 10;
            this.BadWordActive.Text = "Badword filter active";
            this.BadWordActive.UseVisualStyleBackColor = true;
            this.BadWordActive.CheckedChanged += new System.EventHandler(this.BadWordActive_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Spam words";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bad words";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BadWordActive);
            this.Controls.Add(this.SpamCheckBox);
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
        private System.Windows.Forms.CheckBox SpamCheckBox;
        private System.Windows.Forms.CheckBox BadWordActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}