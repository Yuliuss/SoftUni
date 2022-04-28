using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string index = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";
            string numbers = Console.ReadLine();

            MatchCollection numberMatches = Regex.Matches(numbers, index);

            string[] matchNumbers = numberMatches
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ", matchNumbers));
        }
    }
}
