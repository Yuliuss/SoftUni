using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.VehicleCatalogue
{
    class CatalogueVehicle
    {
        public List<Car> Cars { get; }
        public List<Truck> Trucks { get; }

        public CatalogueVehicle()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }
}
