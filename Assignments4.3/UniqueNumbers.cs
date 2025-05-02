using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment4._3_Version2
{
    internal class UniqueNumbers
    {
        public static void unique()
        {
            //Clear methods with 1 purpose and less then 10 lines?
            Console.WriteLine("Input the number of elements");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numberArray = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Input element{i}: ");
                numberArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Dictionary<int, int> frequencyCounter = new Dictionary<int, int>();

            foreach (int i in numberArray)
            {
                if (frequencyCounter.ContainsKey(i))
                    frequencyCounter[i]++;
                else
                {
                    frequencyCounter[i] = 1;
                }
            }
            Console.WriteLine("The unique elements found in the array are:");
            foreach (var i in frequencyCounter)
            {
                if(i.Value == 1)
                {
                    Console.WriteLine(i.Key);
                }
            }



        }
    }
}
