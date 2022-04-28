using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RawData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                cars.Add(new Car(Console.ReadLine().Split()));
            }

            string cargoType = Console.ReadLine();

            if (cargoType == "fragile")
            {
                foreach (var car in cars.Where(c => c.CarsCargo.Type == "fragile"
                                            && c.CarsCargo.Weigth < 1000))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
            else if (cargoType == "flamable")
            {
                foreach (var car in cars.Where(c => c.CarsCargo.Type == "flamable"
                                            && c.CarsEngine.Power > 250))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }
}
