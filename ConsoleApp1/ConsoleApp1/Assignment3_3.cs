using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Assignment3_3
    {
        
        static void Main()
        {
            Console.Write("Enter the number of rows: ");
            if (int.TryParse(Console.ReadLine(), out int rows))
            {
                if (rows > 0)
                {
                    for (int i = 1; i <= rows; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(j);
                        }

                        // Move to the next line after each row is printed
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a positive number of rows.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
