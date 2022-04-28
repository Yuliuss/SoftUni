﻿using System;

namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double comission = -1.0;
            if (city == "Sofia")
            {
                if (0 <= sales && sales <= 500)
                {
                    comission = sales * 0.05;
                }
                else if (500 < sales && sales <= 1000)
                {
                    comission = sales * 0.07;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comission = sales * 0.08;
                }
                else if (10000 <= sales)
                {
                    comission = sales * 0.12;
                }

            }
            else if (city == "Plovdiv")
            {
                if (0 <= sales && sales <= 500)
                {
                    comission = sales * 0.055;
                }
                else if (500 < sales && sales <= 1000)
                {
                    comission = sales * 0.08;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comission = sales * 0.12;
                }
                else if (10000 <= sales)
                {
                    comission = sales * 0.145;
                }

            }
            else if (city == "Varna")
            {
                if (0 <= sales && sales <= 500)
                {
                    comission = sales * 0.045;
                }
                else if (500 < sales && sales <= 1000)
                {
                    comission = sales * 0.075;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comission = sales * 0.1;
                }
                else if (10000 <= sales)
                {
                    comission = sales * 0.13;
                }

            }
            if (comission >= 0)
            {
                Console.WriteLine($"{comission:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
