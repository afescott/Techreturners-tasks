using System;
using System.Linq;

// Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
// Leave punctuation marks untouched.

namespace TechReturners.Tasks
{
    public class Exercise004
    {
        private static int LastLetterPosition = 0;

        public static string PigIt(string str)
        {
            var jumbledString = "";
            
            foreach (var word in str.Split(' '))
            {
                FindLastLetter(word, word.Length - 1);

                if (LastLetterPosition != word.Length - 1)
                {
                    jumbledString += " " + word.Substring
                        (1, word.Length - LastLetterPosition) + word.Substring
                        (0, 1) + "ay" + word.Substring
                        (LastLetterPosition + 1, LastLetterPosition - 1);
                }
                else if (jumbledString == "")
                {
                    jumbledString += word.Substring(1) + word.Substring(0, 1) + "ay";
                }
                else
                {
                    jumbledString += " " + word.Substring(1) + word.Substring(0, 1) + "ay";
                }
            }
            return jumbledString;
        }

        /* Recursive method to determine which character is the last letter in-case the word has punctuation at the end */
        private static void FindLastLetter(string word, int index)
        {
            if (char.IsPunctuation(word.ElementAt(index)))
            {
                FindLastLetter(word, index - 1);
            }
            else
            {
                LastLetterPosition = index;
            }
        }
    }
}

