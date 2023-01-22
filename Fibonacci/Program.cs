using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int indexFibonacci = 8;

            int result = Fibonacci.GetRecursive(indexFibonacci);

            Console.WriteLine($"Recursive result : {result}");

            result = Fibonacci.GetIterative(indexFibonacci);

            Console.WriteLine($"Iterative result : {result}");

        }
    }
}
