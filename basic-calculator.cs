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
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the operator (+, -, *, /): ");
            char op = Console.ReadLine()[0];

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());
        }
    }
}
