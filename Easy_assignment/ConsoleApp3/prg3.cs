using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class prg3
    {
        static void Main()
        {
            string sentence = "It waS a cOLD AND foggy WintEr MorNiNg, I WenT ouT in SearCH of ElusiVe LEoParD";
            string uppercaseSentence = ConvertToUppercase(sentence);
            Console.WriteLine(uppercaseSentence);
        }
        static string ConvertToUppercase(string sentence)
        {
            char[] chars = sentence.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 'a' && chars[i] <= 'z')
                {
                    chars[i] = (char)(chars[i] - 32);
                }
            }
            return string.Join("", chars);
        }

    }

}

