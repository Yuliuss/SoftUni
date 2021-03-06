using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArg = command
                    .Split();
                string type = cmdArg[0]
                    .ToLower();
                string model = cmdArg[1];
                string color = cmdArg[2].ToLower();
                int hp = int.Parse(cmdArg[3]);


                Vehicle currentVehicle = new Vehicle(type, model, color, hp);
                catalogue.Add(currentVehicle);

                command = Console.ReadLine();
            }
            string secondCommand = Console.ReadLine();
            while (secondCommand != "Close the Catalogue")
            {
                string modelType = secondCommand;
                Vehicle printCar = catalogue.First(x => x.Model == modelType);

                Console.WriteLine(printCar);

                secondCommand = Console.ReadLine();
            }

            List<Vehicle> onlyCars = catalogue.Where(x => x.Type == "car").ToList();
            List<Vehicle> onlyTrucks = catalogue.Where(x => x.Type == "truck").ToList();

            double totalCarsHp = onlyCars.Sum(x => x.HorsePower);
            double totalTrucksHp = onlyTrucks.Sum(x => x.HorsePower);

            double avgCarHp = 0.00;
            double avgTruckHp = 0.00;
            if (onlyCars.Count > 0)
            {
                avgCarHp = totalCarsHp / onlyCars.Count;
            }
            if (onlyTrucks.Count > 0)
            {
                avgTruckHp = totalTrucksHp / onlyTrucks.Count;
            }
            Console.WriteLine($"Cars have average horsepower of: {avgCarHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgTruckHp:f2}.");
        }
    }
}
