using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mailClient
{
    public partial class SendingEmail : Form
    {
        MailFunctionality mailFunctionality = new MailFunctionality();
        EmailListData NewEmail = new EmailListData();
        StorageInterface storage = new StorageInterface();
        OpenFileDialog openDialog = new OpenFileDialog();

        string Email = Properties.Settings.Default.Email;
        string Password = Properties.Settings.Default.Password;
        string Server = Properties.Settings.Default.Server;

        public SendingEmail()
        {
            InitializeComponent();
            

        }

        private void Sending_an_Load(object sender, EventArgs e)
        {

        }

        private void ToLabel_Click(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            //first save the textbox to the respective email
            NewEmail.From = Properties.Settings.Default.Email;
            NewEmail.To = EmailTextBox.Text;
            NewEmail.Subject = SubjectTextBox.Text;
            
            NewEmail.Cc = CCTextBox.Text;
            NewEmail.Attachment = AttachmentTextBox.Text;
            if (checkBox1.Checked == true)
            {
                NewEmail.Body = "%%SNAPMAIL%% \n" + BodyRichTextBox.Text;          
            }
            else
            {
                NewEmail.Body = BodyRichTextBox.Text;
            }
          

            //send the email
            mailFunctionality.SendEmailTest(NewEmail, Email, Password, Server);
            bool sent = true;

            if (SaveTheEmail.Checked && sent)
            {
                mailFunctionality.SaveEmail(NewEmail);
            }
            
            if (sent == true)
            {
                MessageBox.Show("Email sent");
                this.Close();
            }
            else
            {
                MessageBox.Show("Email not sent");
            }

            //if checkbox is checked, save the Email
            
            
        }

        private void AttachmentButton_Click(object sender, EventArgs e)
        {
            //Gets the path to the file.
            openDialog.ShowDialog();
            AttachmentTextBox.Text = openDialog.FileName;



        }

        private void SaveTheEmail_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void AttachmentTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
