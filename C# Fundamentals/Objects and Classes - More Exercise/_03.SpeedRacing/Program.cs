using System;
using System.Collections.Generic;

namespace _03.SpeedRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int amountOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < amountOfCars; i++)
            {
                cars.Add(new Car(Console.ReadLine().Split()));
            }

            string[] drive = Console.ReadLine().Split();

            while (drive[0] != "End")
            {
                cars.Find(c => c.Model == drive[1]).Drive(int.Parse(drive[2]));

                drive = Console.ReadLine().Split();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTraveled}");
            }
        }
    }
}
