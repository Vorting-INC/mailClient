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



namespace mailClient
{
    public partial class CreateStorage : Form
    {
        public CreateStorage()
        {
            InitializeComponent();
        }



        private void CreateFileFolder_Click(object sender, EventArgs e)
        {
            
            if (FileFolderName.Text != "")
            {
                if (FileFolderLokation.Text != "")
                {
                    //constructs a storage i
                    StorageInterface Storage = new StorageInterface();
                    //call the create folder from the storage Class
                    Storage.CreateFolder(FileFolderName.Text, FileFolderLokation.Text);


                    //This get the two path from the storage class
                    string FileFolderPath = Storage.GetFileFolderPath();
                    string FileFolderPathAttachments = Storage.GetFileFolderPathAttachments();

                    //saves the path in the setting
                    Properties.Settings.Default["FolderPath"] = FileFolderPath;
                    Properties.Settings.Default["FolderPathAttachments"] = FileFolderPathAttachments;
                    Properties.Settings.Default["StorageCreated"] = true;
                    Properties.Settings.Default.Save();

                    //download all folders and  new emails
                    MailFunctionality mailFunctionality = new MailFunctionality();
                    mailFunctionality.RetrieveFolders(Properties.Settings.Default.Email, Properties.Settings.Default.Password, Properties.Settings.Default.Server);
                    mailFunctionality.DownloadNewEmails(Properties.Settings.Default.Email, Properties.Settings.Default.Password, Properties.Settings.Default.Server);

                    //close form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter a path for the folder");
                }
            }
            else if (FileFolderName.Text == "")
            {
                MessageBox.Show("Please enter a name for the folder");
            }
        }

        
        private void OpenFileManager_Click(object sender, EventArgs e)
       
        {
            StorageInterface Storage = new StorageInterface();
            FileFolderLokation.Text = Storage.OpenFileManager();
        }

        
        private void FileFolderLokation_TextChanged(object sender, EventArgs e)
        {

        }

        private void FileFolderName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateStorage_Load(object sender, EventArgs e)
        {

        }

        private void FileFolderLokationLabel_Click(object sender, EventArgs e)
        {

        }



    }
}