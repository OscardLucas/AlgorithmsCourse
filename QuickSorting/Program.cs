using System;
using System.Linq;

namespace QuickSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input array:");
            int[] myArray = new int[] { 4, 2, 7, 1, 9, 3 };
            //int[] myArray = new int[] { 1, 2 ,3, 4, 5, 6 , 7 };
            //int[] myArray = new int[] { 9 ,8,7,6,4,1 };
            myArray.ToList().ForEach(x => Console.WriteLine(x));

            int [] result = myArray.Sort();
            Console.WriteLine("Sorted array:");
            result.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
