using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("\nEnter a math expression\n\n>>> ");
                    string input = Console.ReadLine().Trim();
                    Console.WriteLine("\nEquals to: " + Calculator(input));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                }
                Console.Write("\nPress Enter to try another string...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static double Calculator(string input)
        {
            double num1 = input[0] - 48.00;
            double num2 = input[2] - 48.00;
            double result = 0;
            switch (input[1])
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }
            return result;
        }
    }
}
