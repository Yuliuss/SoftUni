using System;

namespace _09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());

            double sumOne = sum * 7.61;

            double sumTwo = 0.18 * sumOne;

            double finalSum = sumOne - sumTwo;

            Console.WriteLine($"The final price is:{finalSum} lv.");
            Console.WriteLine($"The discount is:{sumTwo} lv.");

        }
    }
}
