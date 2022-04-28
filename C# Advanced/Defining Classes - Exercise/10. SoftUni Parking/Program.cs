using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Parking parking = new Parking(1);

            Car car = new Car("Audi", "A6", 200, "we1234vc");
            Console.WriteLine(car);
            Console.WriteLine(car.ToString());
        }
    }
}
