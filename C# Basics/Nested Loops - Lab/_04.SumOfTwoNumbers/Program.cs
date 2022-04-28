using System;

namespace _04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            int steps = 0;
            bool flag = false;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {

                    steps++;

                    int currentSum = i + j;

                    if (currentSum == magicalNumber)
                    {
                        Console.WriteLine($"Combination N:{steps} ({i} + {j} = {currentSum})");
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine($"{steps} combinations - neither equals {magicalNumber}");
            }
        }
    }
}
