using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RawData
{
     class Cargo
    {
        public int Weigth { get; set; }
        public string Type { get; set; }

        public Cargo(int weight, string type)
        {
            this.Weigth = weight;
            this.Type = type;
        }
    }
}
