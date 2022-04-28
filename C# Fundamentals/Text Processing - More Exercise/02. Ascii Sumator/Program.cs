using System;

namespace _02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = Console.ReadLine()[0];
            char second = Console.ReadLine()[0];
            string text = Console.ReadLine();

            int start = (int)Math.Min(first, second);
            int end = (int)Math.Max(first, second);

            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                int currentChar = (int)(text[i]);
                if (currentChar > start && currentChar < end)
                {
                    sum += currentChar;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
