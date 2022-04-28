using System;

namespace _05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string country = Console.ReadLine();

                if (country == "End")
                {
                    break;
                }
                double priceOfTrip = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                while (savedMoney < priceOfTrip)
                {
                    double inputMoney = double.Parse(Console.ReadLine());

                    savedMoney += inputMoney;
                }
                Console.WriteLine($"Going to {country}!");
            }
        }
    }
}
