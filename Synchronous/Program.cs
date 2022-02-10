using System;
using System.Threading;

namespace Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Work1();
            Console.WriteLine("..........................");
            Work2();
            Console.ReadLine();
        }
        static void Work1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Work1 is called " + i.ToString());
            }

        }
        static void Work2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Work2 is called " + i.ToString());
            }
        }
    }
}

