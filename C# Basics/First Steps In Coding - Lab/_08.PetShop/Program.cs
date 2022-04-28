using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberDog = double.Parse(Console.ReadLine());
            double numberCat = double.Parse(Console.ReadLine());

            numberDog = numberDog * 2.5;
            numberCat = numberCat * 4;

            double price = numberDog + numberCat;

            Console.WriteLine($"{price} lv.");
        }
    }
}
