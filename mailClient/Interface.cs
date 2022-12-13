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
        
        int MailIndex;

        //string FileFolderPath that can remember the path of the folder we currently have open
        string FileFolderPath = "";

        public Interface()
        {

            InitializeComponent();
            
            //if its the first time logging in
            if (Properties.Settings.Default.StorageCreated == false)
            {
                //Message show that yuor are a new user
                MessageBox.Show("Welcome to Sigmamail, you will have to create local storage before use of the mail functionality");
                //create local storage by opening create storage Form
                CreateStorage createStorage = new CreateStorage();
                createStorage.Show();
                //when the create storage form is closed
                

              
            }

            //retrive folders if local storage exist
            if (Properties.Settings.Default.FolderPath != "" && Properties.Settings.Default.FolderPath != null)
            {
                //RetriveFolder list to box
                RetriveFoldersToListBox();
                //Get new emails from server
                mailFunctionality.DownloadNewEmails(Email, Password, Server);
            }

            //haha
            //dui er til  mænd



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

            //Save the path of the folder we currently have open
            FileFolderPath = path;

            foreach (var item in EmailList)
            {
                //Create a listviewItem that contains items f
                ListViewItem lvi = new ListViewItem(item.From);
                lvi.SubItems.Add(item.Subject);
                lvi.SubItems.Add(item.Date);
                
                if (item.EmailIsSeen == false)
                {
                    //make the text bold if the email is unread
                    lvi.Font = new Font(lvi.Font, FontStyle.Bold);
                    //lvi.BackColor = Color.LightBlue;
                }
                if( item.EmailIsSeen == true)
                {
                    //make the text normal if the email is read
                    lvi.Font = new Font(lvi.Font, FontStyle.Regular);
                }

                EmailListView.Items.Add(lvi);


            }

            
        }

        //function that loads the EmailListView
        private void LoadEmailListView()
        {
            //clear the EmailListView
            EmailListView.Items.Clear();

            foreach (var item in EmailList)
            {
                //Create a listviewItem that contains items f
                ListViewItem lvi = new ListViewItem(item.From);
                lvi.SubItems.Add(item.Subject);
                lvi.SubItems.Add(item.Date);

                if (item.EmailIsSeen == false)
                {
                    //make the text bold if the email is unread
                    lvi.Font = new Font(lvi.Font, FontStyle.Bold);
                    //lvi.BackColor = Color.LightBlue;
                }
                if (item.EmailIsSeen == true)
                {
                    //make the text normal if the email is read
                    lvi.Font = new Font(lvi.Font, FontStyle.Regular);
                }

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
            MailIndex = EmailListView.SelectedIndices[0];
            
            //show the Email selected in the EmailListView in the RecievedEmails textbox
            
        }
        
        
        //function that update the EmailIsSeen property in the EmailListData object by taking the index of the selected item in the EmailListView and if it is seen or not
        public void UpdateEmailIsSeen(int index, bool EmailIsSeen)
            {
                EmailList[index].EmailIsSeen = EmailIsSeen;
           
            
            storageInterface.SaveJsonFile(EmailList[index], EmailList[index].JsonFileName, FileFolderPath);
            }
        
        private void EmailListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Opens a window to show the email selected in the form EmailShow
            var index = EmailListView.SelectedIndices[0];

            //constructs the form emailShow
            EmailShow emailShow = new EmailShow(EmailList[index]);

           


           
            //if its a snapmail is should deleted when opened
            if (EmailList[index].Snap == true)
            {
                //delete the email
                storageInterface.DeleteJsonFile(EmailList[index].JsonFileName, FileFolderPath);
                //remove the email from the EmailList
                EmailList.RemoveAt(index);
                //reload the EmailListView
                LoadEmailListView();
            }
            //if email is not seen
            else if(EmailList[index].EmailIsSeen == false)
            {
                UpdateEmailIsSeen(index, true);
            }

            

            emailShow.Show();
            
        }

        
        




        private void Interface_Load(object sender, EventArgs e)
        {

        }

        private void EmailListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            //reload the list box
            RetrievedFolders.Items.Clear();
            RetriveFoldersToListBox();

            //and reload the emails in the listview
            EmailListView.Items.Clear();
            
        }

        private void SeenButton_Click(object sender, EventArgs e)
        {
            //change the email to seen or unseen depending on its current state
            
            if (EmailList[MailIndex].EmailIsSeen == true)
            {
                UpdateEmailIsSeen(MailIndex, false);
            }
            else
            {
                UpdateEmailIsSeen(MailIndex, true);
            }
            //then update email listview
            LoadEmailListView();

        }
    }
}
