using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Assignment2_2
    {
        static void Main()
        {
            Console.Write("Enter a five - digit number:");
            string input = Console.ReadLine();

            if (input.Length != 5 || !IsDigitsOnly(input))
            {
                Console.WriteLine("Invalid input.Please Enter a valid five digit number");
                return;
            }
            char[] newDigits = new char[5];
            for (int i = 0; i < input.Length; i++)
            {
                int digit = (int)Char.GetNumericValue(input[i]);
                int newDigit = (digit + 1) % 10;
                newDigits[i] = (char)(newDigit + '0');
            }

            string newNumber = new string(newDigits);


            Console.WriteLine($"The new number after adding one to each digit is: {newNumber}");
        }

        static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
           
        }
    }
}
