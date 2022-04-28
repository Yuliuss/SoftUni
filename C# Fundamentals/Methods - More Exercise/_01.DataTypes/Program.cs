using System;

namespace _01.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            DataTaips(input);
        }

        private static void DataTaips(string input)
        {
            if (input == "int")
            {
                int num = int.Parse(Console.ReadLine());
                num *= 2;
                Console.WriteLine(num);
            }
            else if (input == "real")
            {
                double num = double.Parse(Console.ReadLine());
                num *= 1.5;
                Console.WriteLine($"{num:f2}");
            }
            else if (input == "string")
            {
                string name = Console.ReadLine();
                Console.WriteLine($"${name}$");
            }
            return;
        }
    }
}
