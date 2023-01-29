using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSorting
{
    public static class BubbleSorting
    {

        public static void Sort(this int [] array)
        {
            int length = array.Length;

            int k = 0; //Iterations


            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    Console.WriteLine($"Iteration number {k++}");
                    //Swap
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        public static void SortWithSwapFlag(this int[] array)
        {
            int length = array.Length;

            int k = 0; //Iterations

            bool swap = false;

            //[7, 3, 2, 4]
            for(int i = length; i > 0; i--)
            {
                for(int j = 0; j < i-1; j++)
                {
                    Console.WriteLine($"Iteration number {k++}");
                    //Swap
                    if(array[j] > array[j + 1])
                    {
                        swap = true;
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }

                if (!swap) break;
                else swap = false;
            }
        }
    }
}
