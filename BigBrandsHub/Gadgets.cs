using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBrandsHub
{
    internal class Gadgets
    {
        public string Brand { get; set; }
        public string ID { get; set; }
        public decimal Price { get; set; }

        public Gadgets()
        {

        }
        public Gadgets(string brand, string iD, decimal price)
        {
            Brand= brand;
            ID= iD;
            Price= price;
        }
    }
}
