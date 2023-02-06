using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSorting
{
    public static class QuickSorting
    {
        //Take a random pivot
        //Order all lower to the left and higher to the right
        //Now list is divided but not ordered
        //Repeat same step in left and right list and repeat until ger order numbers
        //Mix all the lists


        //4,2,7,1,9,3
        public static int [] Sort(this int [] array)
        {
            return RecursiveSort(array);
        }

        public static int [] RecursiveSort(int [] array)
        {
            int length = array.Length;

            if (length < 2) return array;

            //3
            int indexPivot = length - 1;

            int i = 0;

            while (i < length && indexPivot > 0)
            {
                //swap to the left
                if (array[indexPivot] < array[i])
                {
                    //Just swap and end
                    if (indexPivot - 1 == i)
                    {
                        int temp = array[i];
                        array[i] = array[indexPivot];
                        array[indexPivot--] = temp;
                        break;
                    }
                    else
                    {
                        //Move pivot 1 side to the left
                        int temp = array[indexPivot - 1];
                        array[indexPivot - 1] = array[indexPivot];

                        //Move higher number to the right of the pivot
                        array[indexPivot--] = array[i];

                        //Replace temp value at current index
                        array[i] = temp;
                    }

                }
                //Stays at right
                else
                {
                    i++;
                }
            }

            int[] leftArray = array.GetSubArray(0, indexPivot);
            int[] rightArray = array.GetSubArray(indexPivot + 1, array.Length - (indexPivot + 1));
            return SumSubarrays(RecursiveSort(leftArray), RecursiveSort(rightArray), array[indexPivot]);
        }

        public static int[] SumSubarrays(int [] leftArray, int [] rightArray, int pivote)
        {
            int leftLength = leftArray.Length;
            int rightLenght = rightArray.Length;

            int[] sumedArray = new int[leftLength + rightLenght + 1];

            for(int i = 0; i < leftLength; i++)
            {
                sumedArray[i] = leftArray[i];
            }

            sumedArray[leftLength] = pivote;

            for(int i = leftLength + 1; i < rightLenght + leftLength + 1; i++)
            {
                sumedArray[i] = rightArray[i - (leftLength + 1)];
            }

            return sumedArray;
        }

        /// <summary>
        /// Gets subarray of an input array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="startIndex"></param>
        /// <param name="length"> legnth of the new subarray</param>
        /// <returns></returns>
        private static int[] GetSubArray(this int[] array, int startIndex, int length)
        {
            int[] subArray = new int[length];
            int limit = startIndex + length;

            int indexSubArray = 0;
            for (int i = startIndex; i < limit; i++)
            {
                subArray[indexSubArray] = array[i];
                indexSubArray++;
            }
            return subArray;
        }
    }
}
