using System;
using System.Linq;

namespace InsertionSorting
{
    class Program
    {
        //Its useful when list is already sorted or almost sorted
        //Like yigioh cards xD
        static void Main(string[] args)
        {
            int[] myArray = new int[] {1, 2, 3, 5, 4};
            myArray.Sort();

            myArray.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
