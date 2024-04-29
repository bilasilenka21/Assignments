using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Assignment7
    { 

            static void Main()
            {
                Console.WriteLine("Enter a string:");
                string input = Console.ReadLine();

                int length = CalculateStringLength(input);

                Console.WriteLine($"Length of the string is: {length}");
            }

            static int CalculateStringLength(string str)
            {
                int count = 0;
                foreach (char ch in str)
                {
                    count++; // Increment count for each character
                }
                return count;
            }
        }
    }
    

