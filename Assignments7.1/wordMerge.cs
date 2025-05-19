using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments7._1
{
    class wordMerge
    {
        public static void WordMerge(string wordOne, string wordTwo)
        {
            StringBuilder newWord = new();
            if(string.IsNullOrEmpty(wordOne) || string.IsNullOrEmpty(wordTwo)){
                return;
            }
            string minLen = (wordOne.Length <= wordTwo.Length) ? wordOne : wordTwo;
            int minWordLen = minLen.Length;
            for (int i = 0; i < minWordLen - 1; i++)
            {
                newWord.Append(wordOne[i]);
                newWord.Append(wordTwo[i]);
            }
            if(wordOne.Length > wordTwo.Length)
            {
                newWord.Append(wordOne.Substring(minWordLen));
            }
            else
            {
                newWord.Append(wordTwo.Substring(minWordLen));
            }
                Console.WriteLine(newWord);
        }


    }
}
