using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments6._1
{
    public class Nums
    {   //did not work
        //public static int[] Sort(int[] arrSort)
        //{
        //    int arrLen = arrSort.Length;
        //    if (arrLen == 1) { return arrSort; }
        //    int temp = 0;
        //    for (int i = 0; i< arrLen - 1; i++)
        //    {
        //        if (arrSort[i] == 0)
        //        {
        //            arrSort[i] = arrSort[i + 1];
        //            arrSort[i + 1] = 0;
        //        }
        //    }
        //    return arrSort;
        //}
        public static int[] PushZeros(int[] arr)
        {
            int shiftLeft= 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]!= 0)
                {
                    arr[shiftLeft] = arr[i];
                    shiftLeft++;
                }
            }
            for (int i = shiftLeft; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            return arr;
        }
    }
}
