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
        StorageInterface storageInterface = new StorageInterface();
        //add a global variable to hold the emails in the list
        List<EmailListData> EmailList = new List<EmailListData>();

        
        public Interface()
        {

            InitializeComponent();
            RetriveFoldersToListBox();

     
        }



        public void Interface_Load()
        {
            

        }

        //add folders from the folder FolderPath local storage to the listbox RetrievedFolders and display only the folder name
        public void RetriveFoldersToListBox()
        {
            string[] folders = Directory.GetDirectories(Properties.Settings.Default.FolderPath);
            foreach (string folder in folders)
            {
                RetrievedFolders.Items.Add(Path.GetFileName(folder));
            }
        }

        
        
        







        private void Recieve_Click(object sender, EventArgs e)
        {
            //mailFunctionality.DownloadBodyParts(Email, Password, Server);
            mailFunctionality.DownloadNewEmails(Email, Password, Server);
        }
        

        
        private void RecievedEmails_SelectedIndexChanged(object sender, EventArgs e)
        {  
            
        }


        
        

       //When item in the listbox is selected, display the emails in the folder in the EmailListView
       //this is done by calling the function LoadJsonFiles
        private void RetrievedFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear the EmailListView
            EmailListView.Items.Clear();
            
            string path = Path.Combine(Properties.Settings.Default.FolderPath, RetrievedFolders.SelectedItem.ToString());
            
            EmailList = storageInterface.LoadJsonFiles(path);
            


            foreach (var item in EmailList)
            {
                //Create a listviewItem that contains items f
                ListViewItem lvi = new ListViewItem(item.From);
                lvi.SubItems.Add(item.Subject);
                lvi.SubItems.Add(item.Date);

                EmailListView.Items.Add(lvi);


            }
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


        //opens windows to send an Email
        private void button1_Click(object sender, EventArgs e)
        {
            
            SendingEmail SendingEmail = new SendingEmail();
            SendingEmail.Show();           
        }

        private void EmailListView_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        
        private void EmailListView_MouseClick(object sender, MouseEventArgs e)
        {
            //get the selected item in the listview
            var index = EmailListView.SelectedIndices[0];
            
            //show the Email selected in the EmailListView in the RecievedEmails textbox
            
        }

        private void EmailListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Opens a window to show the email selected in the form EmailShow
            var index = EmailListView.SelectedIndices[0];
            EmailShow emailShow = new EmailShow(EmailList[index]);
            emailShow.Show();

        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }

        private void EmailListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
