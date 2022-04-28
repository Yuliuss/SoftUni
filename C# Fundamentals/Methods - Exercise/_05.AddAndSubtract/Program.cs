using System;

namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sum = Sum(a, b, c);

            Console.WriteLine(sum);
        }

        private static int Sum(int a, int b, int c)
        {
            int sumFirstAndSecond = a + b;
            return Subtract(sumFirstAndSecond, c);
        }

        private static int Subtract(int sumFirstAndSecond, int c)
        {
            return sumFirstAndSecond - c;
        }
    }
}
