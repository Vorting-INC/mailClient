namespace mailClient
{
    partial class LogInScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmailAddressBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.ServerBox = new System.Windows.Forms.TextBox();
            this.RememberCredentials = new System.Windows.Forms.CheckBox();
            this.LogInBotton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(338, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EmailAddressBox
            // 
            this.EmailAddressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressBox.Location = new System.Drawing.Point(250, 354);
            this.EmailAddressBox.Name = "EmailAddressBox";
            this.EmailAddressBox.Size = new System.Drawing.Size(500, 30);
            this.EmailAddressBox.TabIndex = 1;
            this.EmailAddressBox.TextChanged += new System.EventHandler(this.EmailAddressBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(250, 405);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(500, 30);
            this.PasswordBox.TabIndex = 2;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // ServerBox
            // 
            this.ServerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerBox.Location = new System.Drawing.Point(250, 452);
            this.ServerBox.Name = "ServerBox";
            this.ServerBox.Size = new System.Drawing.Size(500, 30);
            this.ServerBox.TabIndex = 3;
            this.ServerBox.TextChanged += new System.EventHandler(this.ServerBox_TextChanged);
            // 
            // RememberCredentials
            // 
            this.RememberCredentials.AutoSize = true;
            this.RememberCredentials.Location = new System.Drawing.Point(250, 499);
            this.RememberCredentials.Name = "RememberCredentials";
            this.RememberCredentials.Size = new System.Drawing.Size(100, 17);
            this.RememberCredentials.TabIndex = 4;
            this.RememberCredentials.Text = "Remember user";
            this.RememberCredentials.UseVisualStyleBackColor = true;
            this.RememberCredentials.CheckedChanged += new System.EventHandler(this.RememberCredentials_CheckedChanged);
            // 
            // LogInBotton
            // 
            this.LogInBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInBotton.Location = new System.Drawing.Point(425, 519);
            this.LogInBotton.Name = "LogInBotton";
            this.LogInBotton.Size = new System.Drawing.Size(150, 50);
            this.LogInBotton.TabIndex = 5;
            this.LogInBotton.Text = "Log in";
            this.LogInBotton.UseVisualStyleBackColor = true;
            this.LogInBotton.Click += new System.EventHandler(this.LogInBotton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Server";
            // 
            // LogInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogInBotton);
            this.Controls.Add(this.RememberCredentials);
            this.Controls.Add(this.ServerBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.EmailAddressBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LogInScreen";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogInScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox EmailAddressBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox ServerBox;
        private System.Windows.Forms.CheckBox RememberCredentials;
        private System.Windows.Forms.Button LogInBotton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

