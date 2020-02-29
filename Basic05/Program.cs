using System;

namespace Basic05
{
    class Program
    {
        /// <summary>
        /// Write a C# Sharp program to swap two numbers.
        /// Test Data:
        /// Input the First Number : 5
        /// Input the Second Number : 6
        /// Expected Output:
        /// After Swapping :
        /// First Number : 6
        /// Second Number : 5 
        /// </summary>
        static void Main()
        {
            double firstNumber, secondNumber, temporaryNumber;

            Console.Write("Input the first number: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Input the second number: ");
            secondNumber = int.Parse(Console.ReadLine());

            // Swap numbers
            temporaryNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temporaryNumber;

            Console.WriteLine($"Numbers after the swap:\n" +
                $"First number: {firstNumber}\n" +
                $"Second number: {secondNumber}");    
        }
    }
}