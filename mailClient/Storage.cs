using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Net.Mail;


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

            //creates a folder for snapmail
            string pathContactList = System.IO.Path.Combine(path, "ContactList");
            System.IO.Directory.CreateDirectory(pathContactList);

            //create a folder for setting file
            string pathSettings = System.IO.Path.Combine(path, "Settings");
            System.IO.Directory.CreateDirectory(pathSettings);





            //save the path to propeties settings
            Properties.Settings.Default["FolderPath"] = path;
            Properties.Settings.Default["FolderPathAttachments"] = pathAttachments;
            Properties.Settings.Default["FolderPathSnapMail"] = pathSnapMail;
            Properties.Settings.Default["FolderPathContactList"] = pathContactList;
            Properties.Settings.Default["FolderPathSettings"] = pathSettings;
            Properties.Settings.Default["StorageCreated"] = true;
            Properties.Settings.Default.Save();
            
            MessageBox.Show("Successfully created a folder");
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

        //Function that loads all the Json files from a folder in storage and stores them in a list of type ContactListData
        public List<ContactListData> LoadJsonFilesContacts(string FolderPath)
        {
            List<ContactListData> ContactList = new List<ContactListData>();
            string[] files = Directory.GetFiles(FolderPath);
            foreach (string file in files)
            {
                if (Path.GetExtension(file) == ".json")
                {
                    string json = File.ReadAllText(file);
                    ContactListData contact = JsonConvert.DeserializeObject<ContactListData>(json);
                    ContactList.Add(contact);
                }
            }
            return ContactList;
        }

        //function that loads a json file from a folder and returns the file as object FilterWordFormat 
       



        



        //function that takes a EmailListdata Object, a Json file name, and a path and saves it as a Json file
        public void SaveJsonFile(Object Email, string JsonFileName, string Path)
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


        //function that moves a  file from one folder to another
        public void MoveFile(string FileName, string Path, string NewPath)
        {
            string FilePath = System.IO.Path.Combine(Path, FileName);
            string NewFilePath = System.IO.Path.Combine(NewPath, FileName);

            if (File.Exists(FilePath))
            {
                File.Move(FilePath, NewFilePath);
            }
        }

        //function that moves a  file from one folder to another folder

        public void MoveFile(string FileName, string Path, string NewPath, string NewFileName)
        {
            string FilePath = System.IO.Path.Combine(Path, FileName);
            string NewFilePath = System.IO.Path.Combine(NewPath, NewFileName);

            if (File.Exists(FilePath))
            {
                File.Move(FilePath, NewFilePath);
            }
        }




    }
}
