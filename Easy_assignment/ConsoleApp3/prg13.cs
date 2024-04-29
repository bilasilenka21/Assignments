using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class prg13
    {
        static void Main()
        {
            Console.Write("Enter a word: ");
            string input = Console.ReadLine();
            string codeWord = CreateCodeWord(input);
            Console.WriteLine("Code word: " + codeWord);
        }
        static string CreateCodeWord(string word)
        {
            string result = "";
            foreach (char c in word)
            {
                if (char.IsLetter(c))
                {
                    char newChar = (char)(c + 3);
                    if ((char.IsUpper(c) && newChar > 'Z') || (char.IsLower(c) && newChar > 'z'))
                    {
                        newChar = (char)(c - 23);
                    }
                    result += newChar;
                }



                else
                {
                    result += c;
                }
            }
            return result;
        }
    }
}
