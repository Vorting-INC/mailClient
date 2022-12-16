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
    public partial class SettingsForm : Form
    {
        StorageInterface storageInterface = new StorageInterface();
        public SettingsForm()
        {
            InitializeComponent();
            //load the SpamWords from storage and put in listbox
            string[] SpamWords = storageInterface.LoadJsonFile("SpamWords", Properties.Settings.Default["FolderPathSettings"].ToString());

        }

        private void AddSpamWordButton_Click(object sender, EventArgs e)
        {
            //add the tekst in the textbox to the SpamWordsBox
            SpamWordsBox.Items.Add(InpuxBox.Text);
            //and save it to the settings file json
            
            

        }
        private void SaveSpamWordButton_Click(object sender, EventArgs e)
        {
            //Save the SpamWordsBox to the FilterWordFormat as a json file
            FilterWordFormat SpamWords = new FilterWordFormat();

            //Create a string that can be save in Json file
            string[] WordsToBeSaves;
            //Initilize the string
            WordsToBeSaves = new string[SpamWordsBox.Items.Count];
            
            //
            foreach (string word in SpamWordsBox.Items)
            {
                WordsToBeSaves[SpamWordsBox.Items.IndexOf(word)] = word;
            }

            SpamWords.Words = WordsToBeSaves;

            //create the file if it does not exist
            storageInterface.SaveJsonFile(SpamWords, "SpamWords.json", Properties.Settings.Default["FolderPathSettings"].ToString());







        }

        private void RemoveSpamWordButton_Click(object sender, EventArgs e)
        {
            //remove the selected item from the SpamWordsBox
            SpamWordsBox.Items.Remove(SpamWordsBox.SelectedItem);
        }

        private void AddBadWordButton_Click(object sender, EventArgs e)
        {
            //Add the selected item to the BadWordsBox
            BadWordsBox.Items.Add(InpuxBox.Text);
        }

        private void RemoveBadWordButton_Click(object sender, EventArgs e)
        {
            //remove the selected item from the BadWordsBox
            BadWordsBox.Items.Remove(BadWordsBox.SelectedItem);
        }

        

        private void SaveBadWordButton_Click(object sender, EventArgs e)
        {

        }
    }


    //Object setting json file class
    public class FilterWordFormat
    {
        public string[] Words { get; set; }
        
    }
}
