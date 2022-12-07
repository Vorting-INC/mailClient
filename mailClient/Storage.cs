using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json;

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



        //Function that loads all the Json files from a folder in storage and stores them in a list of type MailListData
        public List<EmailListData> LoadJsonFiles(string FolderPath)
        {
            List<EmailListData> EmailList = new List<EmailListData>();
            string[] files = Directory.GetFiles(FolderPath);
            foreach (string file in files)
            {
                if (Path.GetExtension(file) == ".json")
                {
                    string json = File.ReadAllText(file);
                    EmailListData email = JsonConvert.DeserializeObject<EmailListData>(json);
                    EmailList.Add(email);
                }
            }
            return EmailList;
        }







    }

}
