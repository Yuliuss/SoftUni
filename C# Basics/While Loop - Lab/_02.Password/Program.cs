using System;

namespace _02.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string inputPassword = Console.ReadLine();


            while (true)
            {
                if (password == inputPassword)
                {
                    break;
                }
                inputPassword = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
