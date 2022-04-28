using System;

namespace _03.Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());
            int steps = 0;

            for (int i = 0; i <= magicNumber; i++)
            {
                for (int j = 0; j <= magicNumber; j++)
                {
                    for (int k = 0; k <= magicNumber; k++)
                    {
                        if (i + j + k == magicNumber)
                        {
                            steps++;
                        }
                    }
                }
            }
            Console.WriteLine(steps);
        }
    }
}
