using System;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double num = 0;
            switch (type)
            {
                case "Premiere":
                    num = 12.00;
                    break;
                case "Normal":
                    num = 7.50;
                    break;
                case "Discount":
                    num = 5.00;
                    break;
            }
            if (type == "Premiere")
            {
                Console.WriteLine($"{rows * columns * num:f2} leva");
            }
            else if (type == "Normal")
            {
                Console.WriteLine($"{rows * columns * num:f2} leva");
            }
            else
            {
                Console.WriteLine($"{rows * columns * num:f2} leva");
            }
        }
    }
}
