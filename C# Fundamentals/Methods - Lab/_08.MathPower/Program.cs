using System;

namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            RaiseToPower(number, power);
        }
        static double RaiseToPower(double number, int power)
        {
            double result = Math.Pow(number, power);

            Console.WriteLine(result);
            return result;
        }
    }
}
