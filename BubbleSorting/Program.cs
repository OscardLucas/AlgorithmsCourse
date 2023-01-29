using System;
using System.Collections.Generic;
using System.Linq;

namespace BubbleSorting
{
    class Program

    //One of the simpliest but one of the least efficient
    //Space copmplexity O(1)
    //Time complexity O(N^2)
    //Works itrating over a list an evaluates current index vs next index, and swapping if unordered
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 2, 3 ,4 ,5,7,9};

            myArray.SortWithSwapFlag();

            myArray.ToList().ForEach(x => Console.WriteLine(x));


            int[] myArray2 = new int[] { 1, 2, 3, 4, 5 ,7,9};

            myArray2.Sort();

            myArray2.ToList().ForEach(x => Console.WriteLine(x));

        }
    }
}
