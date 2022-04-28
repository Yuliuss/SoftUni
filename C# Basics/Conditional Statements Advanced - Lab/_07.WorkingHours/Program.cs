using System;

namespace _07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string days = Console.ReadLine();

            switch (days)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                case "Sunday":
                    break;
            }

            if (hour >= 10 && hour <= 18 && days != "Sunday")
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
