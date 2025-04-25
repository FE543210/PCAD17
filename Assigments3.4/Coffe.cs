using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    public class Coffe : Beverages
    {
        public bool Decaff { get; set; }
        public bool HasMilk { get; set; }
        public String Roast { get; set; }
        
    }
}
