using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    public static class Fibonacci
    {

        //Fibonacci
        //0 1 1 2 3 5 8 13 21 34 ...

        public static int GetIterative(int index)
        {
            int prev1 = 0;
            int prev2 = 0;

            for (int i = 0; i <= index; i++)
            {
                if (i == 0) continue;

                if (i == 1 || i == 2)
                {
                    prev1 = 1;
                }

                else
                {
                    int temp = prev2;
                    prev2 = prev1;
                    prev1 = temp + prev2;

                }
            }

            return prev1 + prev2;
        }

        public static int GetRecursive(int index)
        {
            if (index < 2)
                return index;

            return GetRecursive(index - 1) + GetRecursive(index - 2);
        }


    }
}
