using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StoreBoxes
{
    class Box
    {
        public string SerialNumber { get; set; }
        public string Item { get; set; }
        public int quantity { get; set; }
        public decimal PriceBox { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
