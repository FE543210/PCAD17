using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments6._2
{
    class ProblemTwo
    {
        public static int[] ArrayProducts(int[] arr)
        {
            //Leetcode 238
            int n = arr.Length;
            int[] answer = new int[n];

            int prefix = 1;
            for (int i = 0; i < n; i++) {
                answer[i] = prefix;
                prefix *= arr[i];       
            }
            int postfix = 1;
            for (int i = n-1; i>= 0; i--)
            {
                answer[i] *= postfix;
                postfix *= arr[i];
            }
            return answer;
            
        }
    }
}
