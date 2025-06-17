namespace Assignment7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarsAndParking ParkingLotOne = new CarsAndParking(1,2,3);    
            Console.WriteLine(ParkingLotOne.AddCar(1));
            Console.WriteLine(ParkingLotOne.AddCar(1));
            Console.WriteLine(ParkingLotOne.AddCar(2));
            Console.WriteLine(ParkingLotOne.AddCar(2));
            Console.WriteLine(ParkingLotOne.AddCar(2));
            Console.WriteLine(ParkingLotOne.AddCar(3));
            Console.WriteLine(ParkingLotOne.AddCar(3));
            Console.WriteLine(ParkingLotOne.AddCar(3));
            Console.WriteLine(ParkingLotOne.AddCar(3));


        }
    }
}
