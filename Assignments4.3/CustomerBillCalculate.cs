using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assigment4._3_Version2
{
    public class CustomerBillCalculate
    {
        public string CustomerName{ get; set; }
        public int CustomerId{ get; set; }
        public double CustomerUsageUnits{ get; set; }

        //Reason for not using Case =  working with ranges.
        double CalculateElectricBill(double unit)
        {
            double totalAmount = 0;

            if (unit > 600)
            {
                totalAmount += (unit - 600) * 2.00;
            }
            if (unit >= 400)
            {
                unit -= 400;
                totalAmount += (CustomerUsageUnits - 400) * 1.80;
            }
            if (unit >= 200)
            {
                totalAmount += (CustomerUsageUnits - 600) * 1.50;
            }
            if(unit > 0)
            {
                totalAmount += CustomerUsageUnits * 1.20;
            }
            return totalAmount;
        }

        public void BillDisplay()
        {
            Console.WriteLine("Electricity Bill");
            Console.WriteLine($"Customer ID: {CustomerId}");
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Units Consumer: {CustomerUsageUnits}");
            Console.WriteLine($"Total Amount ${CalculateElectricBill(CustomerUsageUnits):0.00}");

        }
    }
}
