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
                string Email = "askvorting@outlook.com";
                string Server = "imap-mail.outlook.com";
                string Password = "Askhv007";
               
        public Interface()
        {
            
            InitializeComponent();
            //RetrieveFolders(Email, Password, Server);
            MailFunctionality mailFunctionality = new MailFunctionality();
            //mailFunctionality.RetrieveEmailToJson(Email, Password, Server);
            MailFunctionality.DownloadBodyParts(Email, Password, Server);




        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }

        private void Recieve_Click(object sender, EventArgs e)
        {
            
        }
        

        //vil gerne have denne til at ligge i MailFunctionality men det fungere ikke pt da jeg ikke ved hvor jeg skal retrieve mails.
        async void RetrieveFolders(string Email, string Password, string Server)
        {
            using (var client = new ImapClient())
            {
                client.Connect(Server, 993, true);
                client.Authenticate(Email, Password);

                //retrieve last email from server
                var Folders = await client.GetFoldersAsync(new FolderNamespace('.', ""));

                foreach(var item in Folders)
                {
                    RetrievedFolders.Items.Add(item.FullName);
                }

                client.Disconnect(true);


            }
        }
        private void RecievedEmails_SelectedIndexChanged(object sender, EventArgs e)
        {  
            
        }



        async void RetrieveMesseage(string Email, string Password, string Server, string folderName)
        {
            using (var client = new ImapClient())
            {
                client.Connect(Server, 993, true);
                client.Authenticate(Email, Password);

                //retrieve last email from server
                var folder = await client.GetFolderAsync(folderName);

                await folder.OpenAsync(FolderAccess.ReadOnly);

                List<EmailListData> emailList = new List<EmailListData>();

                foreach (var item in folder)
                {
                    emailList.Add(new EmailListData() { 
                        From = item.From.ToString(), 
                        Subject = item.Subject,
                        Date = item.Date.ToString(),
                        Body = item.TextBody,
                        To = item.To.ToString(),
                        CC = item.Cc.ToString(),
                        BCC = item.Bcc.ToString(),
               
                    });



                    for (int i = 0; i < emailList.Count; i++)
                    {
                        string number = i.ToString();
                        RecievedEmails.Items.Add("From " + emailList[i].From + " Subject " + emailList[i].Subject + " Date " + emailList[i].Date + number);
                    }

                }



            }
                
            
        }

       
        private void RetrievedFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            RetrieveMesseage(Email, Password, Server, RetrievedFolders.SelectedItem.ToString());
        }
    }
}
