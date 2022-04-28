﻿using System;
using System.Linq;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                   .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                   .Where(w => w.Length % 2 == 0)
                   .ToList()
                   .ForEach(w =>
                   {
                       Console.WriteLine(w);
                   });
        }
    }
}
