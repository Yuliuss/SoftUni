using System;

namespace _02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumn = 0;
            int maxNum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sumn += number;
                if (number > maxNum)
                {
                    maxNum = number;
                }
            }
            int sumWithoutMax = sumn - maxNum;

            if (sumWithoutMax == maxNum)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                int diff = Math.Abs(maxNum - sumWithoutMax);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
