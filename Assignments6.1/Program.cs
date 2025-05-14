namespace Assignments6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            LList testList = new();
            testList.AddFirst(123,"Ferry St", "Town House");
            testList.AddFirst(243, "Jeferson St", "Town House");
            testList.AddFirst(321, "Lafayette St", "Town House");
            testList.AddFirst(410, "Oak St", "Town House");
            testList.Display();
            Console.WriteLine("After 3 Remove First:");
            testList.RemoveFirst();
            testList.RemoveFirst();
            testList.RemoveFirst();
            testList.Display();
            testList.Search(123);
            testList.Search(124);
            //3
            int[] testOne = [0, 1, 0, 3, 12];
            int[] testTwo = [0];

            Nums.PushZeros(testOne);
            Nums.PushZeros(testTwo);
            Console.WriteLine($"{string.Join(",", testOne)}");
            Console.WriteLine($"{string.Join(",", testTwo)}");

        }
    }
}

