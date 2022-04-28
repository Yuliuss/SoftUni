using System;

namespace _06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            if (symbol == "+")
            {

                double final = num1 + num2;
                if (final % 2 == 0)
                {
                    Console.WriteLine($"{num1} {symbol} {num2} = {final} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} {symbol} {num2} = {final} - odd");
                }
            }
            if (symbol == "-")
            {
                double final = num1 - num2;
                if (final % 2 == 0)
                {
                    Console.WriteLine($"{num1} {symbol} {num2} = {final} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} {symbol} {num2} = {final} - odd");
                }
            }
            if (symbol == "*")
            {
                double final = num1 * num2;
                if (final % 2 == 0)
                {
                    Console.WriteLine($"{num1} {symbol} {num2} = {final} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} {symbol} {num2} = {final} - odd");
                }
            }
            if (symbol == "/")
            {
                if (num1 == 0 || num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    double final = num1 / num2;
                    Console.WriteLine($"{num1} {symbol} {num2} = {final:f2} ");
                }
            }
            if (symbol == "%")
            {
                if (num1 == 0 || num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    double final = num1 % num2;
                    Console.WriteLine($"{num1} {symbol} {num2} = {final}");
                }
            }
        }
    }
}
