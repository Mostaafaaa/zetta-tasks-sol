using System;

namespace SolOfZettaTasks
{
    class Program
    {
        static void Main()
        {
            //Write a method named Calculate that takes two numbers and a string
            /*
            representing an operator ("+","-","*","/") and returns the result.example:
            Console.WriteLine(Calculate(5, 3,"+")); // Output: 8
            */
            Console.WriteLine("-----------------------------1-------------------------------");

            string InputOne, InputTwo, operation;
            float numberOne = 0, numberTwo = 0;

            Console.WriteLine("This is a Calculator for Two Numbers!");

            Console.Write("Please Write Number One: ");
            InputOne = Console.ReadLine();

            Console.Write("Please Write Number Two: ");
            InputTwo = Console.ReadLine();

            Console.Write("Please Select one operator ( '+' , '-' , '*' , '/' ): ");
            operation = Console.ReadLine();

            try
            {
                float result = Calculater(InputOne, InputTwo, operation);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            //--------------------------------------------------------------//
            /*
             Write a method to find the factorial of n numbers (use recursion)
             example:
             int n = 5;
             fact(n); // 120
            */
            Console.WriteLine("-----------------------------2-------------------------------");
            Console.Write("Enter a number to find its factorial: ");
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input); // Try to convert string to int

                if (number < 0)
                {
                    Console.WriteLine("Please enter a non-negative number.");
                    return;
                }
                int result = Factorial(number);
                Console.WriteLine($"Factorial of {number} is: {result}");
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a valid number, \"Must Be Bigger Than Zero\".");
            }
            //--------------------------------------------------------------//
            Console.WriteLine("-----------------------------3-------------------------------");

            int[] numbers = { 1 , 2 , 3 };
            MultiplyAllByTwo(numbers);

            Console.WriteLine("Updated array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " "); 
            }

        }
        //Write a method named Calculate that takes two numbers and a string
        /*
        representing an operator ("+","-","*","/") and returns the result.example:
        Console.WriteLine(Calculate(5, 3,"+")); // Output: 8
        */

        public static float Calculater(string StrNumberOne, string StrNumberTwo, string operation)
        {
            if (!ValidatInput.IsNumber(StrNumberOne) || !ValidatInput.IsNumber(StrNumberTwo))
                throw new ArgumentException("One or both inputs are not valid numbers.");

            if (!ValidatInput.IsOperation(operation))
                throw new ArgumentException("Invalid operation.");

            float numberOne = float.Parse(StrNumberOne);
            float numberTwo = float.Parse(StrNumberTwo);

            switch (operation)
            {
                case "+":
                    return numberOne + numberTwo;
                case "-":
                    return numberOne - numberTwo;
                case "*":
                    return numberOne * numberTwo;
                case "/":
                    if (numberTwo == 0)
                        throw new DivideByZeroException();
                    return numberOne / numberTwo;
                default:
                    throw new Exception("Unknown operation.");
            }
        }
        public static int Factorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        public static void MultiplyAllByTwo(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;
            }
        }
    }
}

