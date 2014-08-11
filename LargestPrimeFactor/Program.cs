using System;

namespace LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            //long largest = 0;

            long num = 600851475143;
            //long i = num;

            long factor = 2;
            long lastFactor = 1;

            while (num > 1)
            {
                if (num % factor == 0)
                {
                    lastFactor = factor;
                    num = num / factor;
                    while (num % factor == 0)
                    {
                        num = num / factor;
                    }
                }
                factor = factor + 1;
            }

            //for (i = num; i > 0; i--)
            //{
            //    if (num % i == 0 && CheckFactor(2, i))
            //    {
            //        largest = i;
            //        break;
            //    }
            //}

            Console.WriteLine("Largest prime factor: {0}", lastFactor);
            Console.ReadLine();
        }

        //private static bool CheckFactor(long start, long num)
        //{
        //    for (long i = start; i < num; i++)
        //    {
        //        if (num % i == 0)
        //            return false;
        //    }
        //    return true;
        //}
    }
}
