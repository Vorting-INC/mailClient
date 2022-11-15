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
    public partial class CreateStorage : Form
    {
        public CreateStorage()
        {
            InitializeComponent();
        }



        private void CreateFileFolder_Click(object sender, EventArgs e)
        {
            string FileName = FileFolderLokation.Text;

            StorageInterface Storage = new StorageInterface();
            Storage.CreateFolder(FileFolderName.Text, FileFolderLokation.Text);


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