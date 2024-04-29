using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hard_assignment
{
    internal class prg5 { 

        public static void Main(string[] args)

        {

            Console.Write("Input any number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            int placeValue = 1;

            while (number > 0)

            {

                int digit = number % 10;

                int placeValueMultiple = digit * placeValue;



                if (placeValueMultiple > 0)

                {

                    Console.WriteLine("{0} - {1}", placeValueMultiple, GetPlaceValueName(placeValue));

                }

                number /= 10;

                placeValue *= 10;

            }

            Console.ReadLine();

        }

        public static string GetPlaceValueName(int placeValue)

        {

            switch (placeValue)

            {

                case 1:

                    return "Units";

                case 10:

                    return "Tens";

                case 100:

                    return "Hundreds";

                case 1000:

                    return "Thousands";

                case 10000:

                    return "Ten Thousands";

                case 100000:

                    return "Hundred Thousands";

                case 1000000:

                    return "Millions";

                default:

                    return "Large Number";

            }

        }

    }

}

