using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSorting
{
    public static class InsertionSorting
    {
        public static void Sort(this int [] array)
        {
            int length = array.Length;

            for(int i = 1; i < length; i++)
            {
                if(array[i] < array [i - 1])
                {               
                    for (int j = i; j > 0; j--)
                    {
                        if (array[j] < array[j - 1])
                        {
                            int temp = array[i];
                            array[j] = array[j - 1];
                            array[j - 1] = temp;
                        }
                        else
                        {
                            break;
                        }

                    }
                }
                
            }
        }
    }
}
