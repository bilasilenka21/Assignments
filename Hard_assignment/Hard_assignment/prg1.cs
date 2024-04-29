using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hard_assignment
{
    internal class prg1
    {
        public static string GeneratePattern(string input)
        {
            string sanitizedInput = Regex.Replace(input, "[^a-zA-Z0-9]", "");

            StringBuilder pattern = new StringBuilder();
            int index = 0;
            bool isDigit = char.IsDigit(sanitizedInput[0]);

            while (index < sanitizedInput.Length)
            {
                char currentChar = sanitizedInput[index];
                bool currentIsDigit = char.IsDigit(currentChar);


                if (currentIsDigit == isDigit)
                {
                    // Skip characters if they don't alternate the type
                    index++;
                }
                else
                {
                    pattern.Append(currentChar);
                    isDigit = !isDigit;
                    index++;
                }
            }

            return pattern.ToString();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter alphanumeric characters: ");
            string userInput = Console.ReadLine();

            string pattern = GeneratePattern(userInput);
            if (pattern.Length > 0)
            {
                Console.WriteLine("Pattern: {0}", pattern);
            }
            else
            {
                Console.WriteLine("No valid pattern can be generated.");
            }
            Console.ReadKey();
        }
    }
}

