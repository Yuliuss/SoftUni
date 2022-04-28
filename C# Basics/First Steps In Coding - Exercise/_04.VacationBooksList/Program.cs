using System;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int sheets = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int a = pages / sheets;
            int b = a / days;

            Console.WriteLine(b);
        }
    }
}
