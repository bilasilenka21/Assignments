using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hard_assignment
{
    internal class prg2
    {
        public static int CalculatePersistence(int number)
        {
            int count = 0;


            if (number < 0)
            {
                return 0;
            }


            while (number > 9)
            {
                int product = 1;
                string numberString = number.ToString();


                foreach (char digitChar in numberString)
                {
                    int digit = int.Parse(digitChar.ToString());
                    product *= digit;
                }

                number = product;
                count++;
            }

            return count;
        }

        public static void Main(string[] args)
        {
            int[] testNumbers = { 39, 999, 4 };

            foreach (int number in testNumbers)
            {
                int persistence = CalculatePersistence(number);
                Console.WriteLine("Multiplicative persistence of {0} is {1}", number, persistence);
            }
            Console.ReadLine();
        }
    }
}
