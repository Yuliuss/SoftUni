using System;
using System.Linq;

namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CatalogueVehicle catalogueVehicle = new CatalogueVehicle();

            while (true)
            {
                string[] input = Console.ReadLine().Split("/");

                if (input[0] == "end")
                {
                    break;
                }

                string typeOfVehicle = input[0];
                string brandOfVehicle = input[1];
                string modelOfVehicle = input[2];
                int horseOrWeight = int.Parse(input[3]);

                if (typeOfVehicle == "Car")
                {
                    catalogueVehicle.Cars.Add(new Car
                    {
                        Brand = brandOfVehicle,
                        Model = modelOfVehicle,
                        HorsePower = horseOrWeight
                    });
                }
                else if (typeOfVehicle == "Truck")
                {
                    catalogueVehicle.Trucks.Add(new Truck()
                    {
                        Brand = brandOfVehicle,
                        Model = modelOfVehicle,
                        Weight = horseOrWeight
                    });
                }
            }

            if (catalogueVehicle.Cars.Count > 0)
            {
                Console.WriteLine($"Cars:");
                foreach (Car carList in catalogueVehicle.Cars.OrderBy(car => car.Brand))
                {
                    Console.WriteLine($"{carList.Brand}: {carList.Model} - {carList.HorsePower}hp");
                }
            }

            if (catalogueVehicle.Trucks.Count > 0)
            {
                Console.WriteLine($"Trucks:");
                foreach (Truck truckList in catalogueVehicle.Trucks.OrderBy(truck => truck.Brand))
                {
                    Console.WriteLine($"{truckList.Brand}: {truckList.Model} - {truckList.Weight}kg");
                }
            }
        }
    }
}
