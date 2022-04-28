using System;

namespace _07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = "square , rectangle , circle , triangle";
            figure = Console.ReadLine();

            if (figure == "square")
            {
                double sum = double.Parse(Console.ReadLine());
                sum = sum * sum;
                Console.WriteLine($"{sum:f3}");
            }
            if (figure == "rectangle")
            {
                double sum = double.Parse(Console.ReadLine());
                double sum2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sum * sum2:f3}");
            }
            if (figure == "circle")
            {
                double sum = double.Parse(Console.ReadLine());
                double area = Math.PI * (sum * sum);
                Console.WriteLine($"{area:f3}");
            }
            if (figure == "triangle")
            {
                double sum1 = double.Parse(Console.ReadLine());
                double sum2 = double.Parse(Console.ReadLine());
                double sum3 = sum1 * sum2 / 2;
                Console.WriteLine($"{sum3:f3}");
            }
        }
    }
}
