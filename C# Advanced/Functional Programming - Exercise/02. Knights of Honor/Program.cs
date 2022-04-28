using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ").ToList();

            List<string> newNames = names.Select(name => $"Sir {name}").ToList();

            Action<List<string>> printNames = n => Console.WriteLine(string.Join(Environment.NewLine, n));

            printNames(newNames);


        }
        static void PrintNamesMethod(List<string> names)
        {
            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
