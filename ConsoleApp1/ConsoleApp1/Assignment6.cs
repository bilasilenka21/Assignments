using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Assignment6
    {
        
        static void Main()
        {
            string sentence = "What do you know about me? Out of everything, I found nothing about you";
            string targetSubstring = "ou";

            int count = CountSubstringOccurrences(sentence, targetSubstring);
            Console.WriteLine($"Number of occurrences of \"{targetSubstring}\": {count}");
        }

        static int CountSubstringOccurrences(string text, string target)
        {
            int p = 0;
            int count = 1;
            int targetLength = target.Length;
            int textLength = text.Length;

            Console.WriteLine(textLength);

            for (int i = 0; i <= textLength - targetLength; i++)
            {
                bool found = true;

                for (int j = 0; j < targetLength; j++)
                {
                    if (text[i + j] != target[j])
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    
                     p += targetLength-1;
                    count++;
                }
            }

            return count;
        }
    }

}

