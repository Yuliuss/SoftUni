using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Engine v12 = new Engine(580, 1200);
            Tire[] tires = new Tire[]
            {
                new Tire(2018, 2.3),
                new Tire(2018, 2.2),
                new Tire(2018, 2.5),
                new Tire(2018, 2.3),
            };

            Car bmw = new Car("BMW", "X6", 1993, 5003, -50, v12, tires);
            Console.WriteLine("Horse power: " + bmw.Engine.HorsePower);

            foreach (var tire in bmw.Tires)
            {
                Console.WriteLine($"{tire.Year} - {tire.Pressure}");
            }



            //Car defaultGolf = new Car();
            //Console.WriteLine($"Default golf: " + defaultGolf.WhoAmI());

            //Car car = new Car();
            //car.Make = "VW";
            //car.Model = "MK3";
            //car.Year = 1992;
            //car.FuelQuantity = 200;
            //car.FuelConsumption = 200;

            //car.Drive(0.5);

            //Console.WriteLine(car.WhoAmI());
        }
    }
}
