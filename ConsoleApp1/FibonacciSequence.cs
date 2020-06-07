using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FibonacciSequence
    {
        public static void Execute()
        {
            Console.WriteLine("===============================");
            foreach (var item in FibonacciSequence.GenerateFibonacis(10))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("===============================");
        }

        //1 1 2 3 5 8 13 21 34 55 
        public static List<int> GenerateFibonacis(int n)
        {
            Console.WriteLine("Enter FibonacciSequence...ex: 1 1 2 3 5 8 13 21 34 55");

            List<int> fb = new List<int>();
            fb.Add(1);
            fb.Add(1);

            for (int i = 2; i < n; i++)
            {
                fb.Add(fb[i - 2] + fb[i - 1]);
            }

            return fb;
        }
    }
}
