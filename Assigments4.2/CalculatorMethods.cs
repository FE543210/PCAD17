using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CalculatorMethods : MethodsInterface
    {
        public double Add(double x, double z)
        {
            return x + z;
        }
        public double Subtract(double x, double z) { 
            return x - z;   
        }
        public double Divide(double x, double z)
        {
            return x / z;
        }
        public double Mutiply(double x, double z)
        {
            return x * z;
        }
    }
}
