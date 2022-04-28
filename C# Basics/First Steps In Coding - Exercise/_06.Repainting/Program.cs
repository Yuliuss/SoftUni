using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            double nailoN = 1.50;
            double Boq = 14.50;
            double razrediteL = 5.00;

            double pNailon = x + 2;
            double pBoq = y + y * 0.1;

            double ppnailon = pNailon * nailoN;
            double ppboq = pBoq * Boq;
            double prazreditel = z * razrediteL;
            double torbi = 0.40;
            double sumMat = ppnailon + ppboq + prazreditel + torbi;
            double summaistor = sumMat * 0.3;
            double sumMmaistor = summaistor * f;
            double sum = sumMat + sumMmaistor;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
