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
using mailClient.ListViewSorter;

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
        
        private ListViewColumnSorter lvwColumnSorter;

        EmailListData SelectedEmail = new EmailListData();
        int MailIndex;

        //string FileFolderPath that can remember the path of the folder we currently have open
        string FileFolderPath = "";

        public Interface()
        {

            InitializeComponent();
            string pathFolder = Path.Combine(Properties.Settings.Default.FolderPath,"Inbox");
            
            //if its the first time logging in
            if (Properties.Settings.Default.StorageCreated == false)
            {
                bool downloaded = false;
                //Message show that yuor are a new user
                MessageBox.Show("Welcome to Sigmamail, you will have to create local storage before use of the mail functionality");
                //create local storage by opening create storage Form
                CreateStorage createStorage = new CreateStorage();
                createStorage.Show();
        
                //when the create storage form is closed run task RetriveFolders_Click
                createStorage.FormClosed += RetriveFolders_Click;



                //wait until there are any folders in the storage
                //check the direktory of the local storage
               


            }
            

            //retrive folders if local storage exist
            if (Properties.Settings.Default.FolderPath != "" && Properties.Settings.Default.FolderPath != null)
            {
                //RetriveFolder list to box
                RetriveFoldersToListBox();
                //Get new emails from server
                
            }
            
           

           
            //For sorting
            lvwColumnSorter = new ListViewColumnSorter();
            this.EmailListView.ListViewItemSorter = lvwColumnSorter;

            //load listview with content of inbox  folder from local storage when opening the form
           

            

            //Save the path of the folder we currently have open
            string FileFolderPath = "";
            FileFolderPath = pathFolder;







            try
            {



                //create a new backgroundWorker object
                BackgroundWorker worker = new BackgroundWorker();

                worker.DoWork += new DoWorkEventHandler(DoWork);

                worker.RunWorkerAsync();

                //call listview_Columnclick to sort the listview by the third column
                EmailListView_ColumnClick(EmailListView, new ColumnClickEventArgs(2));
                //call it a second time to get ascending order, its a stupid way but i aint changing the other thing
                EmailListView_ColumnClick(EmailListView, new ColumnClickEventArgs(2));

                //get the index of inbox in RetrievedFolders listbox
                int index = RetrievedFolders.FindString("Inbox");
                //trigger a click on the inbox folder in the RetrievedFolders listbox
                RetrievedFolders.SetSelected(index, true);

            }

            catch 
            {
               
            }
        }



        //DoWork event handler
        void DoWork(object sender, DoWorkEventArgs e)
        {
            //retrieve new emails every 30 seconds
            while (true)
            {
                System.Threading.Thread.Sleep(30000);
                mailFunctionality.DownloadNewEmails(Email, Password, Server);
                //trigger the load of the listview in the main thread
                try
                {
                    //invoke the reload of Email list view
                    this.Invoke(new MethodInvoker(delegate { LoadEmailListView(); }));
                }
                catch
                {
                    //do noting
                }

            }
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
                //do not add attachments and Contacts folder to the listbox
                if (folder != Properties.Settings.Default.FolderPath + "\\Attachments" 
                    && folder != Properties.Settings.Default.FolderPath + "\\Contacts" 
                    && folder != Properties.Settings.Default.FolderPath + "\\Settings")
                {
                    RetrievedFolders.Items.Add(Path.GetFileName(folder));
                }
                


            }

        }











        private   void Recieve_Click(object sender, EventArgs e)
        {
            //download the new mails in the background running the function in a new thread
            Task.Run(() => mailFunctionality.DownloadNewEmails(Email, Password, Server));
            //load the listview with the new emails
            LoadEmailListView();
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
                if (item.EmailIsSeen == true)
                {
                    //make the text normal if the email is read
                    lvi.Font = new Font(lvi.Font, FontStyle.Regular);
                }

                

                //if the email is flag as important load the icon form imageList1 in column 3
                if (item.Flag == true)
                {
                    lvi.ImageIndex = 0;
                }
                else if (item.Flag == false)
                {
                    lvi.ImageIndex = -1;
                }
                
                EmailListView.Items.Add(lvi);


            }


        }

        //function that loads the EmailListView
        private void LoadEmailListView()
        {   
            //clear the EmailListView
            EmailListView.Items.Clear();
            //reload EmailList from storage
            EmailList = storageInterface.LoadJsonFiles(FileFolderPath);




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

                //if the email is flag as important load the icon form imageList1 in column 3
                if (item.Flag == true)
                {
                    lvi.ImageIndex = 0;
                }
                else if (item.Flag == false)
                {
                    lvi.ImageIndex = -1;
                }
                

            }
        }

        private void RetrieveAllEmail_Click(object sender, EventArgs e)
        {
            //download all mails in the background running the function in a new thread
            Task.Run(() => mailFunctionality.DownloadAllEmails(Email, Password, Server));
            MessageBox.Show("Downloading emails in the background");
        }

        private void RetriveFolders_Click(object sender, EventArgs e)
        {

            Task.Run(() => mailFunctionality.RetrieveFolders(Email, Password, Server));
            
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
            SelectedEmail = EmailList.Find(x => x.Subject == EmailListView.SelectedItems[0].SubItems[1].Text && x.Date == EmailListView.SelectedItems[0].SubItems[2].Text);


            //Set Mailindex to selected item
            MailIndex = EmailListView.SelectedItems[0].Index;


        }


        //function that update the EmailIsSeen property in the EmailListData object by taking the index of the selected item in the EmailListView and if it is seen or not
        public void UpdateEmailIsSeen(EmailListData Email, bool TruthValue)
        {
            Email.EmailIsSeen = TruthValue;
            

            storageInterface.SaveJsonFile(Email, Email.JsonFileName, FileFolderPath);
        }

        private void EmailListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //get the selected item in the listview
            int index = EmailListView.SelectedIndices[0];



            //Get the object from the EmailList that has the same name as the selected item in the EmailListView
            SelectedEmail = EmailList.Find(x => x.Subject == EmailListView.SelectedItems[0].SubItems[1].Text && x.Date == EmailListView.SelectedItems[0].SubItems[2].Text);

            //constructs the form emailShow
            EmailShow emailShow = new EmailShow(SelectedEmail);





            //if its a snapmail is should deleted when opened
            if (SelectedEmail.Snap == true)
            {
                //delete the email
                storageInterface.DeleteJsonFile(SelectedEmail.JsonFileName, FileFolderPath);
                //remove the email from the EmailList
                EmailList.RemoveAt(index);
                //reload the EmailListView
                LoadEmailListView();
            }
            //if email is not seen
            else if (SelectedEmail.EmailIsSeen == false)
            {
                UpdateEmailIsSeen(SelectedEmail, true);
            }


            
            emailShow.Show();

            //reload listview
            LoadEmailListView();
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

            if (SelectedEmail.EmailIsSeen == true)
            {
                UpdateEmailIsSeen(SelectedEmail, false);
                
            }
            else if (SelectedEmail.EmailIsSeen == false)
            {
                UpdateEmailIsSeen(SelectedEmail, true);
            }
           
            //then update email listview
            LoadEmailListView();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //if email is already in junk folder delete the email
            if (RetrievedFolders.SelectedItem.ToString() == "Deleted")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently delete this email?", "Delete Email", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //delete the email
                    storageInterface.DeleteJsonFile(SelectedEmail.JsonFileName, FileFolderPath);
                    //remove the email from the EmailList
                    EmailList.RemoveAt(MailIndex);
                    //reload the EmailListView
                    LoadEmailListView();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }
            }
            else
            {
                //Move the selected email to the junk folder
                storageInterface.MoveFile(EmailList[MailIndex].JsonFileName, FileFolderPath, Properties.Settings.Default.FolderPath + "\\" + "Deleted");
                //reload listview
                EmailList.RemoveAt(MailIndex);
                LoadEmailListView();
            }
        }

      


        //function that sorts the listview
        private void EmailListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView myListView = (ListView)sender;

            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            myListView.Sort();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FlagButton_Click(object sender, EventArgs e)
        {
            //make the currenly selected email flagged or unflagged depending on its current state
            if (SelectedEmail.Flag == true)
            {
                SelectedEmail.Flag = false;
            }
            else if (SelectedEmail.Flag == false)
            {
                SelectedEmail.Flag = true;
            }

            //save the email
            storageInterface.SaveJsonFile(SelectedEmail, SelectedEmail.JsonFileName, FileFolderPath);
            //reload the listview
            LoadEmailListView();
        }

        private void MoveEmailButton_Click(object sender, EventArgs e)
        {
            //move the selected email to arkiv
            storageInterface.MoveFile(SelectedEmail.JsonFileName, FileFolderPath, Properties.Settings.Default.FolderPath + "\\" + "Arkiv");
            //reload listview
            EmailList.RemoveAt(MailIndex);
            LoadEmailListView();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            //open the settings form
            SettingsForm settings = new SettingsForm();
            settings.Show();
            

        }

        //what is lvwColumnSorter?



    }





}
