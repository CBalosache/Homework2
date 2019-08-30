using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero.
            string number1 = "";
            string number2 = "";
            string line;
            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number.

            do
            {
                Console.WriteLine("Type a number (for BMI this number will represent the user weight), and then press Enter");
                number1 = Console.ReadLine();
                double cleanNumber1 = 0;
                while (!double.TryParse(number1, out cleanNumber1))
                {
                    Console.Write("The number is not a valid input. Please enter a double/integer value: ");
                    number1 = Console.ReadLine();
                }
                // Ask the user to type the second number.
                Console.WriteLine("Type another number (for BMI this number will represent the user height), and then press Enter");
                number2 = Console.ReadLine();
                double cleanNumber2 = 0;
                while (!double.TryParse(number2, out cleanNumber2))
                {
                    Console.Write("The number is not a valid input. Please enter a double/integer value: ");
                    number2 = Console.ReadLine();
                }

                // Ask the user to choose an option.
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.WriteLine("\tr - BMI");
                Console.WriteLine("\tq - Quit");
                Console.Write("Your option? ");

                // Use a switch statement to do the math.
                line = Console.ReadLine();
                switch (line)
                {
                    case "a":
                        Operations.addition(cleanNumber1, cleanNumber2);
                        break;
                    case "s":
                        Operations.subtraction(cleanNumber1, cleanNumber2);
                        break;
                    case "m":
                       Operations.multiplication(cleanNumber1, cleanNumber2);
                        break;
                    case "d":
                        Operations.division(cleanNumber1, cleanNumber2);
                        break;
                    case "r":
                        Operations.BMI(cleanNumber1, cleanNumber2);
                        break;
                    case "q":
                        System.Environment.Exit(1);
                        break;
                }
                Console.Out.WriteLine("Would you like to continue? (\tyes or \tno)");
                line = Console.ReadLine();
            } while (line == "yes");
        }
    }
    class Operations
    {
        public static void addition(double num1, double num2)
        {
            Console.WriteLine("Your result: " + (num1 + num2));
        }
        public static void subtraction(double num1, double num2)
        {
            Console.WriteLine("Your result: " + (num1 - num2));
        }
        public static void multiplication(double num1, double num2)
        {
            Console.WriteLine("Your result: " + (num1 * num2));
        }
        public static void division(double num1, double num2)
        {
            if(num2 != 0)
            {
                Console.WriteLine("Your result: " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("The second value has to be different from zero for the division to operate ");
                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }
        }
        public static void BMI(double num1, double num2)
        {
            Console.WriteLine("Your result: " + (num1 / (num2 * num2)));
        }
    }
}