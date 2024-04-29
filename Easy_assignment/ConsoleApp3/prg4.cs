using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class prg4
    {
        static void Main()
        {
            Console.Write("Enter a number to find its prime factors: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Prime Factors of " + number + " = ");
            FindPrimeFactors(number);
        }
        static void FindPrimeFactors(int number)
        {

            int divisor = 2;
            while (number > 1)
            {

                if (number % divisor == 0)
                {
                    Console.Write(divisor);

                    number /= divisor;

                    while (number % divisor == 0)
                    {
                        Console.Write("x" + divisor);
                        number /= divisor;
                    }
                }

                divisor++;
            }
        }
    }



}
