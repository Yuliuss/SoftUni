using System;

namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double savedMoney = 0;

            while (input != "NoMoreMoney")
            {
                double inputMoney = double.Parse(input);

                if (inputMoney < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Increase: {inputMoney:f2}");
                }
                savedMoney += inputMoney;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {savedMoney:f2}");
        }
    }
}
