using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 600851475143;
             for (int i = 1; i< number; i++)
            {
                if (number % i == 0)
                {
                    number = number / i;
                }
            }

            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
