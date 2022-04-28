using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWords = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfWords; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (dictionary.ContainsKey(word))
                {
                    dictionary[word].Add(synonim);
                }
                else
                {
                    dictionary.Add(word, new List<string>() { synonim });
                }
            }

            foreach (var word in dictionary)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value) }");
            }
        }
    }
}
