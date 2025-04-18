using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"7 + 9 = {addMutiply.Add(7, 9)}");
            Console.WriteLine($"1.5 + 2.5 + 1.5 = {addMutiply.Add(1.50f, 2.50f, 1.50f)}");
            Console.WriteLine($"2.5 * 2.5 = {addMutiply.Mutiply(2.5f, 2.5f)}");
            Console.WriteLine($"2.5 * 2.5 * 2.5 = {addMutiply.Mutiply(2.50f, 2.5f, 2.5f)}");
            Console.WriteLine("\n\n");
            Circle circle = new Circle();
            Square square = new();//new version
            circle.ID = 1;
            circle.Radius = 2;
            circle.Name = "Small Circle";
            circle.Color = "Red";
            Console.WriteLine($"The {circle.Color} circle with an id of {circle.ID} and the name of {circle.Name} has an area of {circle.CalculateArea()}");
        }
    } 
    class addMutiply
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static float Add(float x, float y, float z)
        {
            return x + y + z;
        }
        public static float Mutiply(float x, float y)
        {
            return x * y;
        }
        public static float Mutiply(float x, float y, float z)
        {
            return x * y * z;
        }

    }
    abstract class Shape {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public abstract double CalculateArea();
    }
    class Square: Shape
    {
        public double Side { get; set; }
        public override double CalculateArea()
        {
            return Side*Side;
        }
    }
    class Circle: Shape
    {
        public double Radius {  get; set; }
        public override double CalculateArea()
        {
            return Radius * Radius * 3.14;
        }
    }

}
