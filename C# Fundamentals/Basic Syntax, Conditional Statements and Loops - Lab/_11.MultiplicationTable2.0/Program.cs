using System;

namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{num} X {num2} = {num * num2}");
                num2++;
            } while (num2 <= 10);
        }
    }
}
