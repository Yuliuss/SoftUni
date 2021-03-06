using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carData = Console.ReadLine().Split(" ");
                string model = carData[0];
                double fuelAmount = double.Parse(carData[1]);
                double fuelConsumptionForOneKm = double.Parse(carData[2]);

                Car currCar = new Car
                {
                    Model = model,
                    FuelAmount = fuelAmount,
                    FuelConsumptionPerKilometer = fuelConsumptionForOneKm
                };

                cars.Add(currCar);
            }
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandData = command.Split(" ");
                string model = commandData[1];
                double distanceTraveled = double.Parse(commandData[2]);

                Car car = cars.FirstOrDefault(c => c.Model == model);

                bool isDrive = car.Drive(distanceTraveled);

                if (isDrive == false)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

                command = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
