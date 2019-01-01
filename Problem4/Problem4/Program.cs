using System;
using System.Linq;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool found = false;
            int firstHalf = 998, palin = 0;
            int[] factors = new int[2];

            while (!found)
            {
                firstHalf--;
                palin = isPalindrome(firstHalf);
                for (int i = 999; i > 99; i--)
                {
                    if ((palin / i) > 999 || i * i < palin)
                    {
                        break;
                    }

                    if ((palin % i == 0))
                    {
                        found = true;
                        factors[0] = palin / i;
                        factors[1] = i;
                        break;
                    }
                }
            }

            Console.WriteLine("Found the palindrom {0}, which is made from {1}*{2}", palin, factors[0], factors[1]);
            Console.ReadLine();
        }
        public static int isPalindrome(int firstHalf)
        {
            char[] reversed = firstHalf.ToString().Reverse().ToArray();
            return Convert.ToInt32(firstHalf + new string(reversed));
        }
    }        
}
