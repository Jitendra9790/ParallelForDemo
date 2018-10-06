using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ParallelForDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            SequentialFor();
            sw.Stop();
            Console.WriteLine("Time Taken By Sequential For Loop : " + sw.ElapsedMilliseconds);

            sw = Stopwatch.StartNew();
            ParallelFor();
            sw.Stop();
            Console.WriteLine("Time Taken By Parallel For Loop : " + sw.ElapsedMilliseconds);

            Console.ReadKey();
        }

        public static void SequentialFor()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Sequential For : " + i);
                System.Threading.Thread.Sleep(1000);
            }
        }

        public static void ParallelFor()
        {
            Parallel.For(0, 100, i => 
            {
                Console.WriteLine("Parallel For : " + i);
                System.Threading.Thread.Sleep(1000);
            });
        }
    }
}
