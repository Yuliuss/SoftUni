using System;

namespace _04.CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            decimal minutes = hours * 60M;s
            decimal seconds = minutes * 60M;
            decimal milliseconds = seconds * 1000M;
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
