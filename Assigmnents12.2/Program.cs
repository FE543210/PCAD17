namespace Assignment12._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LList testOne = new();
            testOne.AddFirst(6);
            testOne.AddFirst(5);
            testOne.AddFirst(4);
            testOne.AddFirst(3);
            testOne.AddFirst(6);
            testOne.AddFirst(2);
            testOne.AddFirst(1);
            //1 > 2 > 6 > 3 > >4 > 5 > 6
            testOne.Display(testOne.GetHead());
            Console.WriteLine("----------------------");
            Node newhead = testOne.RemoveELements(testOne.GetHead(), 6);
            testOne.Display(newhead);
        }
    }
}
