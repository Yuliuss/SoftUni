using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            numbers.Reverse();

            //Func<int, bool> predicate = num => num % 2 != 0;
            //numbers = numbers.Where(num => num % 2 != 0).ToList();
            Predicate<int> predicate = num => num % n != 0;
            numbers = MyWhere(numbers, predicate);

            Action<List<int>> print = nums => Console.WriteLine(string.Join(" ", nums));
            print(numbers);
        }
        static List<int> MyWhere(List<int> numbers, Predicate<int> predicate)
        {
            List<int> newNumbers = new List<int>();
            foreach (int currNum in numbers)
            {
                if (predicate(currNum))
                {
                    newNumbers.Add(currNum);
                }
            }
            return newNumbers;
        }
    }
}
