using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSorting
{
    public static class MergeSorting
    {
        public static int [] Sort(this int [] array)
        {
            return RecursiveSort(array);
        }

        private static int [] RecursiveSort(int[] array)
        {
            if (array.Length == 1)
                return array;

            int length = array.Length;

            int[] leftArray = array.GetSubArray(0, length / 2);
            int[] rightArray = array.GetSubArray(length / 2, length - length / 2);

            return Merge(RecursiveSort(leftArray), RecursiveSort(rightArray));
        }

        //Divide until we have one item
        //Time Complexity O(N Log(N))
        //Space Complexity O(N)
        //Return merged array in order
        private static int[] Merge(int[] leftArray, int [] rightArray)
        {

            int leftLength = leftArray.Length;
            int rightLength = rightArray.Length;

            int[] mergedArray = new int[leftLength + rightLength];
            int mergedLength = mergedArray.Length;

            int leftIndex = 0;
            int rightIndex = 0;

            for(int i = 0; i < mergedLength; i++)
            {
                //Left index out of range, fill merged array with right array
                if(leftIndex >= leftLength)
                {
                    mergedArray[i] = rightArray[rightIndex++];
                }
                //Right index out of range, fill merged array with left array
                else if(rightIndex >= rightLength)
                {
                    mergedArray[i] = leftArray[leftIndex++];
                }
                //Evaluates which number of both arrays is smaller
                else
                {
                    if (leftArray[leftIndex] <= rightArray[rightIndex])
                    {
                        mergedArray[i] = leftArray[leftIndex++];
                    }
                    else
                    {
                        mergedArray[i] = rightArray[rightIndex++];
                    }
                }
            }

            return mergedArray;
 
        }

        /// <summary>
        /// Gets subarray of an input array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="startIndex"></param>
        /// <param name="length"> legnth of the new subarray</param>
        /// <returns></returns>
        private static int[] GetSubArray(this int [] array, int startIndex, int length)
        {
            int[] subArray = new int[length];
            int limit = startIndex + length;

            int indexSubArray = 0;
            for(int i = startIndex; i < limit; i++)
            {
                subArray[indexSubArray] = array[i];
                indexSubArray++;
            }
            return subArray;
        }
    }
}
