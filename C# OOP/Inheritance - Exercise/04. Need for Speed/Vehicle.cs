﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaulFuelConsumption = 1.25;
        public Vehicle(int horsePower, double fuel)
        {
            this.Fuel = fuel;
            this.HorsePower = horsePower;
        }
        public double Fuel { get; set; }
        public int HorsePower { get; set; }
        public virtual double FuelConsumption => DefaulFuelConsumption;

        public virtual void Drive (double kilometers)
        {
            this.Fuel -= kilometers * this.FuelConsumption;
        }
    }
}
