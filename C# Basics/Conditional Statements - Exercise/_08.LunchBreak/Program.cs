using System;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double episode = int.Parse(Console.ReadLine());
            double breakTime = int.Parse(Console.ReadLine());
            double lunch = breakTime * 0.125;
            double rest = breakTime * 0.25;
            double timeForRest = episode + lunch + rest;
            if (timeForRest <= breakTime)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(breakTime - timeForRest)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(timeForRest - breakTime)} more minutes.");
            }
        }
    }
}
