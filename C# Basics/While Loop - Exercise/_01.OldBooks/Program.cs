using System;

namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            string input = Console.ReadLine();
            bool isFound = false;
            int count = 0;

            while (input != "No More Books")
            {
                if (favBook == input)
                {
                    isFound = true;
                    break;
                }
                count++;
                input = Console.ReadLine();
            }
            if (isFound)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here! {Environment.NewLine} You checked {count} books.");
            }
        }
    }
}
