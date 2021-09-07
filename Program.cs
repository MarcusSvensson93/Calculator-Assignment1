using System;

namespace Calculator_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Marcus Svenssons Calculator. Please select Calculator");

            bool keepLooping = true;

            while (keepLooping)
            {
                Console.WriteLine("---- Menu ----\n1. Calculator\n2. Exit");

                int selection = AskUserForNumber("Your Selection");

                switch (selection)
                {
                    case 1:
                        Calculator();

                        break;

                    case 2:
                        keepLooping = false;
                        Console.WriteLine("Shuting down program");
                        break;

                    default:
                        break;
                }
            }
        }
        static void Calculator()
        {
            Console.WriteLine("You may now use the Calculator!");
            Console.WriteLine("OPS: While using Division, you can't divide by 0");

            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }

            else
            {
                Console.WriteLine("Invalid Operator");
            }
        }

        static int AskUserForNumber(string what)
        {
            bool wasNotNumber = true;
            int number = 0;
            do
            {
                wasNotNumber = !int.TryParse(AskUserFor(what), out number);

            } while (wasNotNumber);

            return number;

        }

        static string AskUserFor(string what)
        {
            Console.Write("Please enter " + what + ": ");

            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}
