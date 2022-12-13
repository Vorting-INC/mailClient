﻿using System;
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

        //constructer that takes an email and sets the to box to it
        public SendingEmail(EmailListData email, string type)
        {
            InitializeComponent();
            //if its a reply
            if (type == "reply")
            {
                //set the to box to the email from
                EmailTextBox.Text = email.From;
                //set the subject box to the email subject
                SubjectTextBox.Text = email.Subject;
                //set the body box to the email body
                BodyRichTextBox.Text = email.Body;
            }
            //if its a forward
            if (type == "forward")
            {
                
                //set the subject box to the email subject
                SubjectTextBox.Text = email.Subject;

                //create a string to hold the body
                string body = "";
                //add a text that says Original message
                body += "---Original message--- \n ";
                //add the email from to the body
                body += "From: " + email.From + "\n";
                //add the email subject to the body
                body += "Subject: " + email.Subject + "\n";
                //add the email date to the body
                body += "Date: " + email.Date + "\n";
                //add the email body to the body
                body += "Body: " + email.Body + "\n";
                //add the body to the body box
                BodyRichTextBox.Text = body;                
            }
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
           

            if (SaveTheEmail.Checked)
            {
                mailFunctionality.SaveEmail(NewEmail);
            }
            
            
            this.Close();
            

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

        private void BodyRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
