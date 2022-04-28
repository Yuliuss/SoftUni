﻿using System;

namespace _04.RefactoringPrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 2; i <= input; i++)
            {
                string isPrime = "true";
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = "false";
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }
        }
    }
}
