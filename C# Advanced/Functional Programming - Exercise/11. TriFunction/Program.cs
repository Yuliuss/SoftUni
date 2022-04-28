using System;
using System.Linq;

namespace _11._TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split();

            Func<string, int, bool> isValidWord = (stringName, num) => stringName.ToCharArray()
                .Select(character => (int)character).Sum() >= num;

            Func<string[], int, Func<string, int, bool>, string> firstValidName =
                (array, number, func) => array
                .FirstOrDefault(str => func(str, number));
            var result = firstValidName(names, sum, isValidWord);
            Console.WriteLine(result);
        }
    }
}
