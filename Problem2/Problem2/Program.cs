using System;
using System.Diagnostics;

namespace Problem2
{
    class Program
    {
        /**/
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();
            int a = 0;
            int b = 1;
            int total = 0;
            int evenTerms = 0;

            while (total < 4000000)
            {
                total = a + b;
                a = b;
                b = total;
                if (total % 2 == 0)
                {
                    evenTerms += total;
                }
            }
            sw.Stop();
            Console.WriteLine(evenTerms);
            Console.WriteLine(sw.ElapsedMilliseconds);

      
            Console.ReadLine();
        }

         }
}
