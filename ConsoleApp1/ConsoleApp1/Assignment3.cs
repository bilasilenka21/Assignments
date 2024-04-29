using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Assignment3
    {
        static void Main()
        {
            string input = "A tiger is a large-hearted gentleman with boundless courage and that when he is exterminated as exterminated he will be unless public opinion rallies to his support India will be the poorer by having lost the finest of her fauna.";

            int countA = 0, countE = 0, countI = 0, countO = 0, countU = 0;

            string lowercaseInput = input.ToLower();

            foreach (char ch in lowercaseInput)
            {
                if (ch == 'a')
                    countA++;
                else if (ch == 'e')
                    countE++;
                else if (ch == 'i')
                    countI++;
                else if (ch == 'o')
                    countO++;
                else if (ch == 'u')
                    countU++;
            }

            Console.WriteLine($"count of a={countA}, e={countE}, i={countI}, o={countO}, u={countU}");
        }
    }

}
 
