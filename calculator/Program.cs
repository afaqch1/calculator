using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero.
            double num1 = 0; 
            double num2 = 0;

            // Display title as the C# console calculator app.
            Console.WriteLine("Techverx Calculator\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("\te - Exit");
            Console.Write("Your option? ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Sum is: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Difference is: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Product is: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
                case "e":
                    break;
            }
           
        }
    }
}