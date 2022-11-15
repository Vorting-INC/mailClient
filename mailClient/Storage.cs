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

        string FileFolderPath = "C:\\Users\\askvo\\Desktop\\mailtest";
        
        //creates a folder in the storage
        public string CreateFolder(string FolderName, string Location)
        {

            string path = System.IO.Path.Combine(Location, FolderName);
            System.IO.Directory.CreateDirectory(path);
            MessageBox.Show("Successfully created a folder");

            return path;
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

        public

        


        

    }

}
