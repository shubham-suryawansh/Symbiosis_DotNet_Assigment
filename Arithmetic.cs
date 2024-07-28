using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbAss1
{
    //Define a Arithmetic class
    class Arithmetic
    {
        // Method to add two numbers
        public void AddNumbers(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Addition of {a} and {b} is: {result}");
        }

        // Method to multiply two numbers
        public void MultiplyNumbers(int a, int b)
        {
            int result = a * b;
            Console.WriteLine($"Multiplication of {a} and {b} is: {result}");
        }
    }
    class Program
    {
        // II. Define the delegate named Operation
        public delegate void Operation(int a, int b);
        static void Main(string[] args)
        {
            // Create an object of Arithmetic class
            Arithmetic arithmetic = new Arithmetic();

            // Create a reference of type Operation
            Operation operation = null;

            // Accept 2 numbers from the user through command line
            Console.WriteLine("Enter the first number:. ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:. ");
            int num2 = int.Parse(Console.ReadLine());

            // Accept a choice from the user
            Console.WriteLine("Choose an operation: 1. Addition 2. Multiplication 3. Both");
            int choice = int.Parse(Console.ReadLine());

            // Depending on user input, add proper methods to the delegate reference
            switch (choice)
            {
                case 1:
                    operation = new Operation(arithmetic.AddNumbers);
                    break;
                case 2:
                    operation = new Operation(arithmetic.MultiplyNumbers);
                    break;
                case 3:
                    operation = new Operation(arithmetic.AddNumbers);
                    operation += arithmetic.MultiplyNumbers;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            // Invoke the delegate
            operation?.Invoke(num1, num2);

            Console.ReadLine();
        }
    }
}
