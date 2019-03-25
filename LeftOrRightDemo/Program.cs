using System;

namespace LeftOrRightDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 12;
            //int b = 3;
            //int c = a % b;
            //if (c == 0)
            //{
            //    Console.WriteLine("这个数能被三整除");
            //}
            //else
            //{
            //    Console.WriteLine("这个数不能能被三整除");
            //}
            //int d = 0;
            //while (d <= 20)
            //{
            //    if(d%3==0)
            //    {
            //        Console.WriteLine(d);
            //    }

            //    d++;
            //}

            for (int i = 0; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
            
        }
    }
}
