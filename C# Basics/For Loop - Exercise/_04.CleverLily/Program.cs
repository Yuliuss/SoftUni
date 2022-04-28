using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            List<double> odd = new List<double>();
            List<double> even = new List<double>();

            double money = 0;
            double toymoney = 0;

            for (int a = age; a > 0; a--)
            {


                if (a % 2 == 0)
                {

                    even.Add(age);

                }
                else
                {
                    odd.Add(age);

                }

            }
            double presentM = 0;

            for (int b = 0; b < even.Count(); b++)
            {

                presentM += 10;
                money = money + presentM - 1;
            }


            toymoney = odd.Count() * toyPrice;

            double checkPrice = toymoney + money;


            if (checkPrice >= price)
            {
                double endPrice = checkPrice - price;
                Console.WriteLine($"Yes! {endPrice:f2}");
            }
            else
            {
                double endMinusPrice = price - checkPrice;
                Console.WriteLine($"No! {endMinusPrice:f2}");
            }

        }
    }
}
