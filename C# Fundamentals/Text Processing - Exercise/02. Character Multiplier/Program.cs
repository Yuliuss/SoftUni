using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine()
               .Split();

            var firstWord = tokens[0];
            var secondWord = tokens[1];

            var longestWord = firstWord;
            var shortestWord = secondWord;

            if (firstWord.Length < secondWord.Length)
            {
                longestWord = secondWord;
                shortestWord = firstWord;
            }
            var total = CharacterMultiplier(longestWord, shortestWord);
            Console.WriteLine(total);
        }

        public static int CharacterMultiplier(string longestWord, string shortestWord)
        {
            var sum = 0;

            for (int i = 0; i < shortestWord.Length; i++)
            {
                var multiply = longestWord[i] * shortestWord[i];
                sum += multiply;
            }

            for (int i = shortestWord.Length; i < longestWord.Length; i++)
            {
                sum += longestWord[i];
            }

            return sum;
        }
    }
}
