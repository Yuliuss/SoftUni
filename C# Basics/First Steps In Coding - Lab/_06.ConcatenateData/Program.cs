using System;

namespace _06.ConcatenateData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string family = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string city = Console.ReadLine();

            Console.WriteLine($"You are {name} {family}, a {age}-years old person from {city}.");
        }
    }
}
