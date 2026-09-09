using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This asks the user for the two numbers and the operator
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter the operator (+, -, *, /): ");
            char op = Console.ReadLine()[0];

            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();
            
            // This validates whether the inputs are valid numbers
            if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2))
            {
                // When the user wants to add the numbers together
                if (op == '+')
                {
                    double ans = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {ans}");
                }

                // When the user wants to subtract the numbers
                if (op == '-')
                {
                    double ans = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {ans}");
                }

                // When the user wants to multiply the numbers
                if (op == '*')
                {
                    double ans = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {ans}");
                }

                // When the user wants to divide the numbers
                if (op == '/')
                {
                    if (num2 != 0)
                    {
                        double ans = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {ans}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                }

                // User validation for the operator
                if (op != '+' || op != '-' || op != '*' || op != '/')
                {
                    Console.WriteLine("Error: Invalid operator. Please use +, -, *, or /.");
                }

            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter valid numbers.");
            }
        }
    }
}
