using System;

namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pens = double.Parse(Console.ReadLine());
            double markers = double.Parse(Console.ReadLine());
            double liters = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double a = 5.80;
            double b = 7.20;
            double c = 1.20;

            double pensCost = pens * a;
            double markersCost = markers * b;
            double litersCost = liters * c;
            double TotalCost = pensCost + markersCost + litersCost;

            double discountNumber = discount / 100;

            double finalPrice = (TotalCost - (TotalCost * discountNumber));

            Console.WriteLine(finalPrice);

        }
    }
}
