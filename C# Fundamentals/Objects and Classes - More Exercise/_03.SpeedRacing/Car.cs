using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SpeedRacing
{
    class Car
    {
        public string Model { get; set; }
        public decimal FuelAmount { get; set; }
        public decimal FuelConsumptionPerKm { get; set; }
        public int DistanceTraveled { get; set; }

        public Car(string[] carCharacteristics)
        {
            this.Model = carCharacteristics[0];
            this.FuelAmount = decimal.Parse(carCharacteristics[1]);
            this.FuelConsumptionPerKm = decimal.Parse(carCharacteristics[2]);

        }

        public void Drive(int distance)
        {
            decimal fuelNeeded = distance * this.FuelConsumptionPerKm;

            if (this.FuelAmount >= fuelNeeded)
            {
                this.DistanceTraveled += distance;
                this.FuelAmount -= fuelNeeded;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
