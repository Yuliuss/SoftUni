using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            double depositDue = double.Parse(Console.ReadLine());
            double yearlyInterest = double.Parse(Console.ReadLine());

            double one = depositSum * (yearlyInterest / 100);
            double two = one / 12;
            double three = depositSum + (depositDue * two);

            Console.WriteLine(three);
        }
    }
}
