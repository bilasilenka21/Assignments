using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hard_assignment
{
    internal class prg3
    {

        public static void DisplayDigits(int number)

        {

            if (number < 10)

            {

                Console.Write("{0} ", number);

                return;

            }



            Console.Write("{0} ", number % 10);

            DisplayDigits(number / 10);

        }

        public static void Main(string[] args)

        {

            Console.Write("Input any number: ");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The digits in the number {0} are: ", num);

            DisplayDigits(num);

            Console.WriteLine();

            Console.ReadLine();
        }
    }
    }
