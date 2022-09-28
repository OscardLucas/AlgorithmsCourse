using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class Factorial
    {
        /// <summary>
        /// Get factorial value by recursive method
        /// </summary>
        /// <param name="Number"></param>
        /// <returns></returns>
        public static long GetFactorialRecursive(int Number)
        {
            if (Number < 1)
                throw new Exception("Number must be greater than zero");

            //Base
            if (Number == 1)
                return Number;

            return Number * GetFactorialRecursive(Number - 1);
        }

        /// <summary>
        /// Get factorial value by iterative method
        /// </summary>
        /// <param name="Number"></param>
        /// <returns></returns>
        public static long GetFactorialIterative(int Number)
        {
            if (Number < 1)
                throw new Exception("Number must be greater than zero");

            int result = 1;

            for (int i = 1; i <= Number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
