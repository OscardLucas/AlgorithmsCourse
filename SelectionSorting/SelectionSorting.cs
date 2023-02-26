using System;
using System.Collections.Generic;
using System.Text;

namespace SelectionSorting
{
    public static class SelectionSorting
    {


        public static void Sort(this int [] array)
        {
            if (array.Length == 0) return;

            int length = array.Length;

            //[4, 2, 1]
            for(int i = 0; i < length; i++)
            {
                int indexSmallest = i;

                for(int j = i; j < length; j++)
                {
                    if(array[j] < array[indexSmallest])
                    {
                        indexSmallest = j;
                    }
                }

                int temp = array[i];
                array[i] = array[indexSmallest];
                array[indexSmallest] = temp;
            }


        }
    }
}
