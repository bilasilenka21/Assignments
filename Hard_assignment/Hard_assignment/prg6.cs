using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hard_assignment
{
    internal class prg6
    {
 

        public static double CalculateAngle(int hour, int minute)

        {

            if (hour < 1 || hour > 12 || minute < 0 || minute > 59)

            {

                throw new ArgumentException("Invalid hour or minute. Hour must be between 1 and 12, and minute must be between 0 and 59.");

            }



            double minuteAngle = minute * 6;



            double hourAnglePart1 = hour * 30;



            double minuteContribution = minute * 0.5;

            double hourAnglePart2 = minuteContribution;



            double hourAngle = hourAnglePart1 - hourAnglePart2;



            double angleDifference = Math.Abs(minuteAngle - hourAngle);

            angleDifference = Math.Min(angleDifference, 360 - angleDifference);

            return angleDifference;

        }

        public static void Main(string[] args)

        {

            Console.WriteLine("Enter hour (1-12): ");

            int hour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter minute (0-59): ");

            int minute = Convert.ToInt32(Console.ReadLine());

            try

            {

                double angle = CalculateAngle(hour, minute);

                Console.WriteLine("The angle between hour hand and minute hand is {0} degrees", angle);

            }

            catch (ArgumentException ex)

            {

                Console.WriteLine("Error: {0}", ex.Message);

            }

            Console.ReadLine();

        }

    }

}

