using System;
using System.Diagnostics;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberToTest = 9000;


            Stopwatch sw1 = new Stopwatch();
            Stopwatch sw2 = new Stopwatch();

            sw1.Start();
            long result = Factorial.GetFactorialRecursive(NumberToTest);
            sw1.Stop();

            sw2.Start();
            long result2 = Factorial.GetFactorialIterative(NumberToTest);
            sw2.Stop();
            Console.WriteLine($"Time elapsed for recursive method: {sw1.Elapsed.TotalMilliseconds}");
            Console.WriteLine($"Time elapsed for iterative method: {sw2.Elapsed.TotalMilliseconds}");

        }



    }
}
