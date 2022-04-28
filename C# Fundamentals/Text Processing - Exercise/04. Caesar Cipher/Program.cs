using System;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            foreach (char ch in input)
            {
                var currentChar = (char)(ch + 3);
                Console.Write(currentChar);
            }
        }
    }
}
