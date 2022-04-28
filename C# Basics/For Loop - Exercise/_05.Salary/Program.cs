﻿using System;

namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Facebook = 150;
            const int Instagram = 100;
            const int Reddit = 50;
            int openedBrowsers = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i <= openedBrowsers; i++)
            {
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
                string browsers = Console.ReadLine();
                if (browsers == "Facebook")
                {
                    salary -= Facebook;
                }
                else if (browsers == "Instagram")
                {
                    salary -= Instagram;
                }
                else if (browsers == "Reddit")
                {
                    salary -= Reddit;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
