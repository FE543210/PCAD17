namespace Assigment4._3_Version2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //The class implementation was not needed, just wanted to practice.
            CustomerBillCalculate customer = new();
            Console.Write("PLease enter customer id: ");
            customer.CustomerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter name: ");
            customer.CustomerName = Console.ReadLine();
            Console.Write("Enter Units used: ");
            customer.CustomerUsageUnits = Convert.ToDouble(Console.ReadLine());
            customer.BillDisplay();

        }
    }
}
