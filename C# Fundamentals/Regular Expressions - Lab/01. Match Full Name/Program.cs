using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var patten = new Regex(@"\b([A-Z][a-z]+) ([A-Z][a-z]+)");

            MatchCollection mathe = patten.Matches(text);


            foreach (Match item in mathe)
            {
                Console.Write("{0} ", string.Join(" ", item));
            }
        }
    }
}
