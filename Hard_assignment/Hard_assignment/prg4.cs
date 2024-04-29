using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hard_assignment
{
    internal class prg4

    {

        public static int CountDigits(int number)

        {

            if (number == 0)

            {

                return 0;

            }

            return 1 + CountDigits(number / 10);

        }

        public static void Main(string[] args)

        {

            Console.Write("Input any number: ");

            int num = Convert.ToInt32(Console.ReadLine());

            int digitCount = CountDigits(num);

            Console.WriteLine("The number {0} contains the number of digits: {1}", num, digitCount);

            Console.ReadLine();

        }

    }

}

