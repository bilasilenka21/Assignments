using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Assignment7_3
    {
        static void Main()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Original Array:");
            PrintArray(numbers);

            int positionToDelete = 2; 

            if (positionToDelete < 1 || positionToDelete > numbers.Length)
            {
                Console.WriteLine($"Invalid position. Position should be between 1 and {numbers.Length}.");
                return;
            }

            numbers = DeleteElementAtPosition(numbers, positionToDelete);

            Console.WriteLine($"\nArray after deleting element at position {positionToDelete}:");
            PrintArray(numbers);
        }

        static int[] DeleteElementAtPosition(int[] array, int position)
        {
            int[] newArray = new int[array.Length - 1];
            int newArrayIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i != position - 1) 
                {
                    newArray[newArrayIndex] = array[i];
                    newArrayIndex++;
                }
            }

            return newArray;
        }

        static void PrintArray(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}

