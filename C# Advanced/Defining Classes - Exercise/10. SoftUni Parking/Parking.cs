using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new List<Car>();
        }

        public int Count => this.cars.Count;
        public string AddCar(Car car)
        {
            if (this.cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            if (this.cars.Count == this.capacity)
            {
                return "Parking is full!";
            }
            this.cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar (string registrationNumber)
        {
            Car car = this.cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
            if (car == null)
            {
                return "Car with that registration number, doesen't exist!";
            }
            this.cars.Remove(car);
            return $"Successfully removed {registrationNumber}";
        }
        public Car GetCar(string registratonNumber) => this.cars.
            FirstOrDefault(c => c.RegistrationNumber == registratonNumber);

        public void RemoveSetOfRegistration(List<string> RegistrationNumbers)
        {
            this.cars = this.cars.Where(c => !RegistrationNumbers
            .Contains(c.RegistrationNumber)).ToList();
        }
    }
}
