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

                    SplashForm.ShowSplashScreen();

                    //download all folders and  new emails
                    MailFunctionality mailFunctionality = new MailFunctionality();
                    mailFunctionality.RetrieveFolders(Properties.Settings.Default.Email, Properties.Settings.Default.Password, Properties.Settings.Default.Server);
                    mailFunctionality.DownloadAllEmails(Properties.Settings.Default.Email, Properties.Settings.Default.Password, Properties.Settings.Default.Server);

                    //close form
                    Interface Interface = new Interface();
                    this.Close();
                    SplashForm.CloseForm();
                    Interface.Show();
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