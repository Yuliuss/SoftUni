using System;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            PrintInBetween(a, b);
        }

        private static void PrintInBetween(char a, char b)
        {
            if (a > b)
            {
                char first = a;
                a = b;
                b = first;
            }

            for (int i = a + 1; i < b; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
