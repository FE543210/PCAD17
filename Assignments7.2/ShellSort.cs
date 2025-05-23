using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments7._2
{
    class Shells
    {
        public static void ShellSort(int[] arr)
        {
            int gap = arr.Length / 2;
            int i, j;
            while(gap > 0)
            {
                i = gap;
                while(i< arr.Length)
                {
                    int temp = arr[i];
                    j = i - gap;
                    while(j>=0 && arr[j] > temp)
                    {
                        arr[j + gap] = arr[j];
                        j = j - gap;
                    }
                    arr[j + gap] = temp;
                    i++;
                }
                gap = gap / 2;
            }
        }
    }
}
