using System;

namespace _03.FloatingEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double epsilon = 0.000001;
            if (first < second)
            {
                double temp = first;
                first = second;
                second = temp;

            }
            if (first - second < epsilon)
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
