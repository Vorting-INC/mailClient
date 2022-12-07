using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mailClient
{
    public partial class EmailShow : Form
    {
        //constructer that takes in the email data
        public EmailShow(EmailListData email)
        {
            InitializeComponent();
            //set the textboxes to the email data
            FromBox.Text = email.From;
            SubjectBox.Text = email.Subject;
            DateBox.Text = email.Date;
            BodyRichBox.Text = email.Body;
            //if there is an attachment 
            if (email.Attachment != "" && email.Attachment != null)
            {
                //show the attachment file name
                AttachmentBox.Text = email.Attachment;
                //if its a picture show it in the picture box
                if (email.Attachment.Contains(".jpg") || email.Attachment.Contains(".png") || email.Attachment.Contains(".gif"))
                {
                    pictureBox1.ImageLocation = email.Attachment;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FromBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubjectBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BodyRichBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailShow_Load(object sender, EventArgs e)
        {
            //takes the data from the listbox and displays it in the textboxes
            
        }

        private void OpenAttachment_Click(object sender, EventArgs e)
        {
            //Open explore to the location of the attachment
            System.Diagnostics.Process.Start("explorer.exe", AttachmentBox.Text);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
