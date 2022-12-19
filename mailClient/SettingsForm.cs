using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            //load the spams and bad words from the settings file using the storage interface
            //load the spam words
            FilterWordFormat SpamWords = new FilterWordFormat();            
            SpamWords = storageInterface.LoadJsonFileFilterWords(Path.Combine(Properties.Settings.Default["FolderPathSettings"].ToString(), "SpamWords.json"));

            //load the bad words
            FilterWordFormat BadWords = new FilterWordFormat();
            BadWords = storageInterface.LoadJsonFileFilterWords(Path.Combine(Properties.Settings.Default["FolderPathSettings"].ToString(), "BadWords.json"));

            try
            {
                //load the spam words into the listbox only if there are any words
                if (SpamWords != null)
                {

                    foreach (string word in SpamWords.Words)
                    {

                        SpamWordsBox.Items.Add(word);
                    }
                }

                //load the bad words into the listbox only if there are any words
                if (BadWords != null)
                {
                    foreach (string word in BadWords.Words)
                    {
                        BadWordsBox.Items.Add(word);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading the words from the settings file");
            }

            //load the checkboxes
            if (Properties.Settings.Default.SpamFilterActive)
            {
                SpamCheckBox.Checked = true;
            }
            else
            {
                SpamCheckBox.Checked = false;
            }
            
            if (Properties.Settings.Default.BadWordFilterActive)
            {
                BadWordActive.Checked = true;
            }
            else
            {
                BadWordActive.Checked = false;
            }
            

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
                //add the word to the string
                WordsToBeSaves[SpamWordsBox.Items.IndexOf(word)] = word.ToLower();
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
            //Save the BadWordsBox to the FilterWordFormat as a json file
            FilterWordFormat BadWords = new FilterWordFormat();

            //Create a string that can be save in Json file
            string[] WordsToBeSaves;
            //Initilize the string
            WordsToBeSaves = new string[BadWordsBox.Items.Count];

            //
            foreach (string word in BadWordsBox.Items)
            {
                WordsToBeSaves[BadWordsBox.Items.IndexOf(word)] = word.ToLower();
            }

            BadWords.Words = WordsToBeSaves;

            //create the file if it does not exist
            storageInterface.SaveJsonFile(BadWords, "BadWords.json", Properties.Settings.Default["FolderPathSettings"].ToString());

        }

        private void SpamCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //if the spam checkbox is checked then save the setting to true
            if (SpamCheckBox.Checked)
            {
                Properties.Settings.Default.SpamFilterActive = true;
            }
            else
            {
                Properties.Settings.Default.SpamFilterActive = false;
            }
            //save the settings
            Properties.Settings.Default.Save();

        }

        private void BadWordActive_CheckedChanged(object sender, EventArgs e)
        {
            //if the bad word checkbox is checked then save the setting to true
            if (BadWordActive.Checked)
            {
                Properties.Settings.Default.BadWordFilterActive = true;
            }
            else
            {
                Properties.Settings.Default.BadWordFilterActive = false;
            }
            //save the settings
            Properties.Settings.Default.Save();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BadWordsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


    //Object setting json file class
    public class FilterWordFormat
    {
        public string[] Words { get; set; }
        
    }
}
