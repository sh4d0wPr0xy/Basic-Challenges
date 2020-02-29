using System;

namespace Basic04
{
    class Program
    {
        /// <summary>
        /// Write a C# Sharp program to print the result of the specified operations.
        /// -1 + 4 * 6
        /// ( 35+ 5 ) % 7
        /// 14 + -4 * 6 / 11
        /// 2 + 15 / 6 * 1 - 7 % 2 
        /// </summary>
        static void Main()
        {
            // Equation 1
            Console.WriteLine(-1 + 4 * 6);

            // Equation 2
            Console.WriteLine((35 + 5) % 7);

            // Equation 3
            Console.WriteLine(14 + -4 * 6 / 11);

            // Equation 4
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }
    }
}