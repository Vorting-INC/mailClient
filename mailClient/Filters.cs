using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mailClient
{
    internal class Filters
    {
        
        


        //SnapMail code
        string SnapMail = "%%SNAPMAIL%%";


        // Bad word we want to filter out
        
        
        public static string CensorFlaggedWords(string input, string[] flaggedWords)
        {
            MessageBox.Show("Running Cencor word");
            // Split the input string into words and iterate over each word
            foreach (string word in input.Split(' '))
            {
                
                // Check if the current word is a flagged word, where capital letters or smaller letters does not matter
                if (flaggedWords.Contains(word))
                {
                    string replacement = word.Substring(0, 1);
                    for (int i = 1; i < word.Length; i++)
                    {
                        replacement += "*";
                    }
                    // If the word is a flagged word, replace it with censored version
                    input = input.Replace(word, replacement);
                }
            }

            // Return the censored string
            return input;
        }

        public static bool SpamFilter(string input, string[] SpamWords)
        {
            int Result = 0;
            // Split the input string into words and iterate over each word
            foreach (string word in input.Split(' '))
            {
                // Check if the current word is a flagged word, where capital letters or smaller letters does not matter
                if (word != null && SpamWords.Contains(word.ToLower()) && Properties.Settings.Default.SpamFilterActive == true)
                {
                    return true;
                }
                
            }


            // Return the censored string
            return false;
        }


        //create a general purpose filter method that takes a The class EmailListData, 
        //it should have a bool deciding if it need to filder out bad words
        //It should be able to search words and then decide which folder to put the new email in

        public static void Filter(EmailListData email, bool FilterBadWords )
        {
            
            
            
        }





        //Create a filter that takes a object EmailListData that can decide if the mail is a SNAPMAIL by looking for %%SNAPMAIL%
        //If the mail is a Snapmail then it should change EmailListData.SnapMail = true
        //and move the mail into the folder SnapMail in the Local Storage
        //Because SnapMail code would always be first in a body it should only look trhough the firstwords in the body
        //it should also remove the snapmail code from the body after storing the bool as true
        public string SnapMailFilter(EmailListData email)
        {
            string SnapMail = "%%SNAPMAIL%%";
            // Split the input string into words and iterate over each word
            foreach (string word in email.Body.Split(' '))
            {
                //create a counter to only look at the first 3 words to make it more effecient
                int counter = 0;
                // Check if the current word is a flagged word, where capital letters or smaller letters does not matter
                if (SnapMail == word)
                {
                    email.Snap = true;
                    email.Body = email.Body.Replace(word, "");
                    
                }
                counter++;
                
                if (counter == 4)
                {
                    break;
                }
            }
            //returns a path to the new folder
            return SnapMail;
        }





    }
}
