using System;

namespace _10.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num >= 100 && num <= 200 || num == 0)
            {
                Console.WriteLine();
            }
            else if (num < 100)
            {
                Console.WriteLine("invalid");
            }
            else if (num > 200)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
