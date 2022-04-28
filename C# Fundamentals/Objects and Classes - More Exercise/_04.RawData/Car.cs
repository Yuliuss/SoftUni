using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RawData
{
     class Car
    {
        public string Model { get; set; }
        public Engine CarsEngine { get; set; }
        public Cargo CarsCargo { get; set; }

        public Car(string[] carInfo)
        {
            this.Model = carInfo[0];
            this.CarsEngine = new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2]));
            this.CarsCargo = new Cargo(int.Parse(carInfo[3]), carInfo[4]);
        }
    }
}
