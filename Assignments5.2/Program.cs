using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace Assignments5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //1
            Console.WriteLine(LastWordLenght("The quick brown fox jumps over the lazy dog"));
            Console.WriteLine(LastWordLenght("The quick brown fox jumps over the lazy  dog"));
            Console.WriteLine(LastWordLenght("The quick brown fox jumps over the lazy dog "));
            //2
            NaturalNumbersHead(10);
            Console.WriteLine();
            //3
            NaturalNumbersTail(10);
            Console.WriteLine();
            //4
            Console.WriteLine(isXPalindrome("RADAR"));
            Console.WriteLine(isXPalindrome(" "));
            Console.WriteLine(isXPalindrome("race a car"));
        }
        //1
        public static int LastWordLenght(string wordPhrase) {
            if (string.IsNullOrEmpty(wordPhrase))
            {
                Console.WriteLine("String is null or empty.");
                return -1;
            }
            //int wordCount = 0;
            //Does not work for test #3.
            //int LastWordIndex = wordPhrase.LastIndexOf(" ");
            //int wordCount = 0;
            //for (int i = LastWordIndex + 1; i < wordPhrase.Length; i++)
            //    {
            //        wordCount++;
            //    }
            //return wordCount;
            string[] words = wordPhrase.Split(' ', StringSplitOptions.RemoveEmptyEntries); //Works for #3
            string lastWord = words[words.Length-1];
            return lastWord.Length; //or foreach loop through lastWord with a char
        }
        //2
        static void NaturalNumbersHead(int x)
        {
            if(x>0){
                NaturalNumbersHead(x - 1);
                Console.Write($"{x} ");
            }   
        }
        //3
        static void NaturalNumbersTail(int x)
        {
            if (x > 0)
            {
                Console.Write($"{x} ");
                NaturalNumbersTail(x - 1);
            }            
        }
        //4
        public static bool isXPalindrome(string x)
        {
            x.ToUpper().Trim();
            while (x.Length > 1)
            {
                if (x[0] != x[x.Length - 1])
                {
                    return false;
                }
                else
                {
                    return isXPalindrome(x.Substring(1, x.Length - 2));
                }    
            }
            return true;
        }

    }
}
