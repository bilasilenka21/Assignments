using System;
namespace ConsoleApp1
{
    internal class Assignment2
    {
        static void Main()
        {
            string inpString = "Deep#sea#fishing#is#a#dangerous#occupation#because#of#the#rough#sea";
            int nthWord = 6;
            string result = StrNthWord(inpString, nthWord);
            Console.WriteLine("output string:" + result);
            Console.ReadLine();
        }

        static string StrNthWord(string inpString, int nth)
        {
            string[] words = inpString.Split('#');
            words = Array.FindAll(words, word => !string.IsNullOrWhiteSpace(word));
            if (nth >= 1 && nth <= words.Length)
            {
                return words[nth - 1];
            }

            else
            {
                return "invalid";

            }

        }

    }
}


