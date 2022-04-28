using System;

namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int total = 0;
            int isScpecialNum = 0;
            bool toe = false;
            for (int i = 1; i <= num1; i++)
            {
                isScpecialNum = i;
                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }
                toe = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine($"{isScpecialNum} -> {toe}");
                total = 0;
                i = isScpecialNum;
            }
        }
    }
}
