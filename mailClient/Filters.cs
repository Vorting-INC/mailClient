using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mailClient
{
    internal class Filters
    {


        // Bad word we want to filter out
        string[] flaggedWordsList = { "nigger", "fuck", "cunt", "shit", "fucking", "ass", "pussy", "dick", "tiananmen", "square", "nudes" };
        string SnapMail = "%%SNAPMAIL%%";
        static string CensorFlaggedWords(string input, string[] flaggedWords)
        {
            // Split the input string into words and iterate over each word
            foreach (string word in input.Split(' '))
            {
                // Check if the current word is a flagged word, where capital letters or smaller letters does not matter
                if (flaggedWords.Contains(word.ToLower()))
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

        static int SpamOrSnap(string input, string[] flaggedWords)
        {
            int Result = 0;
            // Split the input string into words and iterate over each word
            foreach (string word in input.Split(' '))
            {
                // Check if the current word is a flagged word, where capital letters or smaller letters does not matter
                if (flaggedWords.Contains(word.ToLower()))
                {
                    Result = 1;
                }
                //Check %%SNAPMAIL%% set value to 2
                if("%%SNAPMAIL%%" == word)
                {
                    Result = 2;
                }
            }
            

            // Return the censored string
            return Result;
        }




        
    }
}
