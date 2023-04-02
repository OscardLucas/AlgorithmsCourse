using System;
using System.Diagnostics;

namespace Fibonacci
{
    class Program
    {

        //Recursion is more readable but time complexity is O(2^N) vs O(N) of iterative, but iterative could be less readable and complex
        
        //Recursion = Dry and readable Cons: Large Stack

        //Every time you are using a tree or converting something to a tree, consider recursion
        //Divide and conquer using recursion


        static void Main(string[] args)
        {
            int indexFibonacci = 45;
            int result = 0;


            result = FibonacciDynamic.GetResult(indexFibonacci, new System.Collections.Generic.Dictionary<int, int>());
            Console.WriteLine($"Dynamic programming result : {result}");

            result = Fibonacci.GetRecursive(indexFibonacci);
            Console.WriteLine($"Recursive result : {result}");

            result = Fibonacci.GetIterative(indexFibonacci);
            Console.WriteLine($"Iterative result : {result}");



        }
    }
}
