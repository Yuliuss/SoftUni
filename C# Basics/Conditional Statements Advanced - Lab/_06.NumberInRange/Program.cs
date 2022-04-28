using System;

namespace _06.NumberInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num >= 1 && num <= 100)
            {
                Console.WriteLine("Yes");
            }
            else if (num >= -100 && num <= -1)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
