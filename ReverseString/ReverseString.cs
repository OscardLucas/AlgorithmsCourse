using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseString
{
    public static class ReverseString
    {
        public static string Reverse(string str)
        {
            int length = str.Length;

            if (length <= 1)
                return str;

            return str[length - 1] + Reverse(str.Remove(length-1));

        }


    }
}
