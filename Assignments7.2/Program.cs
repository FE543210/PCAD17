namespace Assignments7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testOne = { 1, 3,-1,0, 2, 5, 4, 6, 8, 7 };
            Shells.ShellSort(testOne);
            Console.WriteLine(string.Join(" ", testOne));

            Console.WriteLine($"hellO reversed is: {Reverse.vowels("hellO")}");
            Console.WriteLine($"avacado reversed is: {Reverse.vowels("avacado")}");
            Console.WriteLine($"intelligent reversed is: {Reverse.vowels("intelligent")}");
        }
    }
}
