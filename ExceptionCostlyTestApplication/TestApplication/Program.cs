using System;
using System.Diagnostics;

namespace TestAppliaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Division of 2 Numbers");
            Console.Write("Dividend: ");
            int a = 100;
            Console.WriteLine("Note: Divisor should not be 0!");
            Console.Write("Divisor: ");
            int b = 0;

            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 10000; i++)
            {
                if (divideByZero(a, b))
                {
                    Console.WriteLine(a / b);
                }
                else
                {
                    Console.WriteLine("Note: Divisor should not be 0!");
                }

                //if (divideByZeroWithExceptionHandling(a, b))
                //{
                //    Console.WriteLine(a / b);
                //}
                //else
                //{
                //    Console.WriteLine("Note: Divisor should not be 0!");
                //}
            }

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.ReadKey();

        }

        public static bool divideByZero(int a, int b)
        {
            if (b == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool divideByZeroWithExceptionHandling(int a, int b)
        {
            try
            {
                int qoutient = a / b;
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
