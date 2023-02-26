using System;
using System.Linq;

namespace SelectionSorting
{
    class Program
    {
        //Works finding the smallest and moving to first position and continue looking the smallest
        //Space copmplexity O(1)
        //Time complexity O(N^2)
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 3,2,6,1,4,7,5 };

            myArray.Sort();

            myArray.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
