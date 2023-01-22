using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Ho";

            string result = ReverseString.Reverse(message);

            Console.WriteLine(result);
        }
    }
}
