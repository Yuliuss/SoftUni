using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] firstArray = new string[n];
            string[] secondtArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] currentArray = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
                string indexZeroElement = currentArray[0];
                string indexOneElement = currentArray[1];

                if (i % 2 == 0)
                {
                    firstArray[i] = indexZeroElement;
                    secondtArray[i] = indexOneElement;
                }
                else if (i % 2 == 1)
                {
                    firstArray[i] = indexOneElement;
                    secondtArray[i] = indexZeroElement;
                }
            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondtArray));
        }
    }
}
