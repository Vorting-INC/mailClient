using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using MailKit.Net.Imap;
using MailKit;
using System.Reflection.Emit;

namespace mailClient
{
    public partial class Interface : Form
    {
        string Email = Properties.Settings.Default.Email;
        string Server = Properties.Settings.Default.Server;
        string Password = Properties.Settings.Default.Password;
        MailFunctionality mailFunctionality = new MailFunctionality();
        public Interface()
        {
            
            InitializeComponent();
            //RetrieveFolders(Email, Password, Server);
            
            
            
            //mailFunctionality.RetrieveEmailToJson(Email, Password, Server);
            //MailFunctionality.DownloadBodyParts(Email, Password, Server);




        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }

        private void Recieve_Click(object sender, EventArgs e)
        {
            //mailFunctionality.DownloadBodyParts(Email, Password, Server);
            mailFunctionality.DownloadNewEmails(Email, Password, Server);
        }
        

        
        private void RecievedEmails_SelectedIndexChanged(object sender, EventArgs e)
        {  
            
        }


        
        

       
        private void RetrievedFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        
        }

        private void RetrieveAllEmail_Click(object sender, EventArgs e)
        {
            //call function to retrieve all emails
            mailFunctionality.DownloadAllEmails(Email, Password, Server);
        }

        private void RetriveFolders_Click(object sender, EventArgs e)
        {
            
            mailFunctionality.RetrieveFolders(Email, Password, Server);
        }

        private void CreateStorageButton_Click(object sender, EventArgs e)
        {
            CreateStorage createStorage = new CreateStorage();
            createStorage.Show();
            
        }
    }
}
