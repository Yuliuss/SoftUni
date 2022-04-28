using System;

namespace _03.NewHouse
{
    internal class Program
    {
        static double rosesPrice = 5;
        static double dahliasPrice = 3.80;
        static double tulipsPrice = 2.80;
        static double narcissusPrice = 3;
        static double gladiolusPrice = 2.50;
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int numberFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double totalPrice = 0;

            if (flowers == "Roses")
            {
                if (numberFlowers > 80)
                {
                    totalPrice -= numberFlowers * rosesPrice * 0.10;
                }
                totalPrice += numberFlowers * rosesPrice;
            }
            else if (flowers == "Dahlias")
            {
                if (numberFlowers > 90)
                {
                    totalPrice -= numberFlowers * dahliasPrice * 0.15;
                }
                totalPrice += numberFlowers * dahliasPrice;
            }
            else if (flowers == "Tulips")
            {
                if (numberFlowers > 80)
                {
                    totalPrice -= numberFlowers * tulipsPrice * 0.15;
                }
                totalPrice += numberFlowers * tulipsPrice;
            }
            else if (flowers == "Narcissus")
            {
                if (numberFlowers < 120)
                {
                    totalPrice += numberFlowers * narcissusPrice * 0.15;
                }
                totalPrice += numberFlowers * narcissusPrice;
            }
            else
            {
                if (numberFlowers < 80)
                {
                    totalPrice += numberFlowers * gladiolusPrice * 0.20;
                }
                totalPrice += numberFlowers * gladiolusPrice;
            }
            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flowers} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }
        }
    }
}
