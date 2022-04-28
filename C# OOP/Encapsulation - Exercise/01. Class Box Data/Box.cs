using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double Length
        {
            get => this.length;
            private set
            {
                this.ThrowIfInvalidSide(value, nameof(this.length));
                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                this.ThrowIfInvalidSide(value, nameof(this.width));
                this.width = value;
            }
        }
        public double Height
        {
            get => this.height;
            private set
            {
                this.ThrowIfInvalidSide(value, nameof(this.height));
                this.height = value;
            }
        }

        public double CalculateVolume()
        {
            return this.Width * this.Length * this.Height;
        }
        public double CalculateLateralSurfaceArea()
        {
            return 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        }
        public double CalculateSurfaceArea()
        {
            return 2 * this.Length * this.Width + 
                   2 * this.Length * this.Height + 
                   2 * this.Width * this.Height;
        }

        private void ThrowIfInvalidSide(double value, string side)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{side} cannot be zero or negative.");
            }
        }
    }
}
