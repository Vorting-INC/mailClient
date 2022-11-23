using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mailClient
{
    internal class StorageInterface
    {

        string FileFolderPath = "";
        string FileFOlderPathAttachments = "";

        //creates a folder in the storage
        public void CreateFolder(string FolderName, string Location)
        {

            string path = System.IO.Path.Combine(Location, FolderName);
            System.IO.Directory.CreateDirectory(path);
            string pathAttachments = System.IO.Path.Combine(path, "Attachments");
            System.IO.Directory.CreateDirectory(pathAttachments);
            MessageBox.Show("Successfully created a folder");

            FileFolderPath = path;
            FileFOlderPathAttachments = pathAttachments;           

        }
        


        //create a file in storage
        public void CreateFile(string FileName, string Path)
        {
            string file = System.IO.Path.Combine(Path, FileName);
            if (!System.IO.File.Exists(FileName))
            {
                System.IO.File.Create(FileName);
            }
        }

        public string OpenFileManager()
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            
            if (FBD.ShowDialog() == DialogResult.OK)
                    {
                        FileFolderPath = FBD.SelectedPath;
                    }
                     FileFolderPath = FBD.SelectedPath;

            return FBD.SelectedPath;
        }

        public string GetFileFolderPath()
        {
            return FileFolderPath;
        }

        public string GetFileFolderPathAttachments()
        {

            return FileFOlderPathAttachments;
        }








    }

}
