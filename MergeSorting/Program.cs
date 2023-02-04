using System;
using System.Linq;

namespace MergeSorting
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Input array:");
            int[] myArray = new int[] { 2, 5, 1, 20, 4, 8, 11, 6,7};
            myArray.ToList().ForEach(x => Console.WriteLine(x));

            int [] result = myArray.Sort();
            Console.WriteLine("Sorted array:");
            result.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
