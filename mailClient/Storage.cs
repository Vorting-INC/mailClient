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
        string FileFolderPathSnapMail = "";

        //creates a folder in the storage
        public void CreateFolder(string FolderName, string Location)
        {
            //creates a generel purpose folder for storage
            string path = System.IO.Path.Combine(Location, FolderName);
            System.IO.Directory.CreateDirectory(path);
            //creates a folder for attachments
            string pathAttachments = System.IO.Path.Combine(path, "Attachments");
            System.IO.Directory.CreateDirectory(pathAttachments);
            //creates a folder for snapmail
            string pathSnapMail = System.IO.Path.Combine(path, "Snapmail");
            System.IO.Directory.CreateDirectory(pathSnapMail);



            MessageBox.Show("Successfully created a folder");

            FileFolderPath = path;
            FileFOlderPathAttachments = pathAttachments;
            FileFolderPathSnapMail = pathSnapMail;

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

        //get the path of the folder from the local storage on a computer by user input
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

        public string GetFileFolderPathSnapMail()
        {
            return FileFolderPathSnapMail;
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


        //function that takes a EmailListdata Object, a Json file name, and a path and saves it as a Json file
        public void SaveJsonFile(EmailListData Email, string JsonFileName, string Path)
        {

            string jsonfile = JsonConvert.SerializeObject(Email, Formatting.Indented);
            string FilePath = System.IO.Path.Combine(Path, JsonFileName);

            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }

            using (var tw = new StreamWriter(FilePath, true))
            {
                tw.WriteLine(jsonfile.ToString());
                tw.Close();
            }
        }

        //function the deletes a Json file from storage
        public void DeleteJsonFile(string JsonFileName, string Path)
        {
            string FilePath = System.IO.Path.Combine(Path, JsonFileName);
           
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }







        }
    }
}
