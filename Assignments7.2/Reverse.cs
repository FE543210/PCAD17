using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments7._2
{
    class Reverse
    {
        public static string vowels(string word)
        {
            //Edge case
            if (string.IsNullOrEmpty(word)) { return word; }

            //Create char[] copy of word
            char[] wordChar = word.ToCharArray();
            int left = 0;
            int right = word.Length-1;

            //Can modify to add extra letters, like 'à', can also use HasSet--> HashSet<char>
            string vowels = "aeiouAEIOU";

            while (left < right)//intelligent -- > Left = 0 and Right = 10
            {
                
                //wordChar = [i,n,t,e,l,l,i,g,e,n,t]
                while (left < right && !vowels.Contains(wordChar[left])) { left++; }
                //0->'i'
                while (left < right && !vowels.Contains(wordChar[right])) { right--; }
                //8->'e'
                char temp = wordChar[left]; //temp = 'i'
                wordChar[left] = word[right];// [e,n,t,e,l,l,i,g,e,n,t]
                wordChar[right] = temp;// [e,n,t,e,l,l,i,g,i,n,t] 
                left++; // left = 1
                right--; // right = 7
            }
            return new string(wordChar);//[e,n,t,i,l,l,e,g,i,n,t] to string--> entillegint


            //- 1 while loop, O(n)
            ////static string ReverseVowels(string str)
            //{
            //    if (str == null || str.Length == 0) return str;

            //    string vowels = "aeiouAEIOU";
            //    char[] charArray = str.ToCharArray();
            //    int i = 0, j = str.Length - 1;
            //    while (i < j)
            //    {
            //        if (vowels.Contains(charArray[i]) && vowels.Contains(charArray[j]))
            //        {
            //            char temp = charArray[i];
            //            charArray[i] = charArray[j];
            //            charArray[j] = temp;
            //            i++;
            //            j--;
            //        }
            //        if (!vowels.Contains(str[i])) i++;
            //        if (!vowels.Contains(str[j])) j--;
            //    }
            //    return new string(charArray);
            //}

        }
    }
}
