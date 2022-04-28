using System;

namespace _08.CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string days = Console.ReadLine();

            int num = 0;

            switch (days)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    num = 12;
                    break;
                case "Wednesday":
                case "Thursday":
                    num = 14;
                    break;
                case "Saturday":
                case "Sunday":
                    num = 16;
                    break;
            }
            Console.WriteLine(num);
        }
    }
}
