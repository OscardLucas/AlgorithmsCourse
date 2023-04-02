using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    public static class FibonacciDynamic
    {
        public static int GetResult(int num, Dictionary<int, int> cache)
        {
            if (num < 2) return num;

            if (cache.ContainsKey(num))
            {
                return cache[num];
            }
            else
            {
                return cache[num] = GetResult(num - 1, cache) + GetResult(num - 2, cache);
            }
        }

    }


}
