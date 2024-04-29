using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class prg7
    {
        static void Main()
        {


            Console.Write("enter a string :\n");
            string str = Console.ReadLine();
            Strfun(str);
        }
        static void Strfun(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                bool b = true;
                for (int j = 0; j < i; j++)
                {
                    if (chars[j] == chars[i])
                    {
                        b = false;

                    }
                }
                if (b)
                {
                    Console.Write(chars[i]);
                }


            }
        }

    }





}
