using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hard_assignment
{
    internal class prg7
    {


        public static string GetLongestPalindrome(string str)

        {

            int n = str.Length;

            bool[,] dp = new bool[n, n];



            for (int i = 0; i < n; i++)

            {

                dp[i, i] = true;

                if (i < n - 1 && str[i] == str[i + 1])

                {

                    dp[i, i + 1] = true;

                }

            }



            int maxLength = 1;

            int start = 0;



            for (int len = 3; len <= n; len++)

            {

                for (int i = 0; i < n - len + 1; i++)

                {

                    int j = i + len - 1;



                    if (str[i] == str[j] && dp[i + 1, j - 1])

                    {

                        dp[i, j] = true;

                        if (len > maxLength)

                        {

                            maxLength = len;

                            start = i;

                        }

                    }

                }

            }

            return str.Substring(start, maxLength);

        }

        public static void Main(string[] args)

        {

            string input = "bananas";

            string longestPalindrome = GetLongestPalindrome(input);

            Console.WriteLine("Longest palindrome in '{0}' is '{1}'", input, longestPalindrome);

            Console.ReadLine();

        }

    }

}

