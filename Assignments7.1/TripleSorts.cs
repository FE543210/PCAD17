using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments7._1
{
    class TripleSorts
    {
        public static void BubbleSort(int[] arr)
        {

            //Stable O(n^2)
            int temp;
            for (int i = 0; i< arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length - (1 + i); j++)
                {
                    if (arr[j]> arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }

                }
            }
        }
        public static void SelectionSort(int[] arr)
        {
            //Unstable O(n^2)
            int minIndex= 0;
            int temp = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                minIndex = i;
                for(int j = i+1; j< arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                     minIndex = j;
                    }
                    
                }
                temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
        public static void InsertionSort(int[] arr)
        {
            for(int i = 1; i< arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while(j>= 0 && arr[j]> temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }
        public static void Display(int[] arr) {
            for(int i = 0; i < arr.Length-1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
