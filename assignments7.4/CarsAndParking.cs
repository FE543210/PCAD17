using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7._4
{
    class CarsAndParking
    {
        public int smallCars { get; set; }
        public int mediumCars { get; set; }
        public int largeCars { get; set; }
        public CarsAndParking(int large = 0, int medium = 0, int small = 0)
        {
            this.smallCars = small;
            this.mediumCars = medium;
            this.largeCars = large;
        }
        public bool AddCar(int carSize)
        {   
            switch (carSize)
            {
                case 3:
                    if(smallCars > 0)
                    {
                        smallCars--;
                        return true;
                    }
                break;
                case 2:
                    if (mediumCars > 0)
                    {
                        mediumCars--;
                        return true;
                    }
                    break;
                case 1:
                    if (largeCars > 0)
                    {
                        largeCars--;
                        return true;
                    }
                    break;

            }
            return false;
        }
    }
}
