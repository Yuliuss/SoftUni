using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split(' ').Select(int.Parse).Reverse().ToList();
            List<int> sequence2 = new List<int>();
            foreach (var num in sequence)
            {
                if (num > 0)
                {
                    sequence2.Add(num);
                }
            }
            if (sequence2.Count < 1)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", sequence2));
            }
        }
    }
}
