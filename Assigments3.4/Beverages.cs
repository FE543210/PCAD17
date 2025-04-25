using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    public abstract class Beverages
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public bool Hot { get; set; }
    }
}
