using System;

namespace Assignments6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            ArrayStack myArray = new ArrayStack(10, [1,2,3,4,5,6,7,8,9]);
            //Display
            Console.WriteLine("Display:");
            myArray.Display();
            //Push
            Console.WriteLine("Display after Push 11:");
            myArray.Push(11);
            myArray.Display();
            //Try Pushing but the array is full
            Console.WriteLine("Try Pushing but the array is full:");
            myArray.Push(1);
            //Pop letting openning 1 space in the stack, display then push into new space on the stack
            Console.WriteLine("Pop letting openning 1 space in the stack, display then push into new space on the stack:");
            myArray.Pop();
            myArray.Display();
            Console.WriteLine("Peek:");
            //Peek
            myArray.Peek();

            //2
            int[] testOne = { 1, 2, 3, 4 };
            int[] resultOne = ProblemTwo.ArrayProducts(testOne);
            int[] testTwo = { -1, 1, 0, -3, 3 };
            int[] resultTwo = ProblemTwo.ArrayProducts(testTwo);
            Console.WriteLine("#2: ");
            Console.WriteLine(string.Join(",",resultOne));
            Console.WriteLine(string.Join(",", resultTwo));
            Console.ReadKey();
        }
    }
}
