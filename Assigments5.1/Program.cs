using System.Diagnostics.CodeAnalysis;

namespace Assignments5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Check if -121 is palindrome = {IsXPalindrome(-121)}");
            Console.WriteLine($"Check if 1223 is palindrome = {IsXPalindrome(1223)}");
            Console.WriteLine($"Check if 121 is palindrome = {IsXPalindrome(121)}");
            Console.WriteLine($"Check if 1221 is palindrome = {IsXPalindrome(1221)}");
            Console.WriteLine($"The sum of 12345 is = {SumAll(12345)}");
            Console.WriteLine($"The sum of -12345 is = {SumAll(-12345)}");
            Console.WriteLine($"Testing an int array of 1,2,3,4,5,1 is = {uniqueNumbers([1,3,4,5,1])}");
            Console.WriteLine($"Testing an int array of 1,2,3,4,5 = {uniqueNumbers([1,2,3,4,5])}");

        }
        //1
        //public static bool IsXPalindrome(int x)
        //{
        //    if (x < 0) return false;
        //    string palindromeArray = x.ToString();
        //    int palindromeLenght = palindromeArray.Length;
        //    {
        //        for (int i = 0; i < palindromeLenght / 2; i++)
        //        {
        //            if (palindromeArray[i] != palindromeArray[palindromeLenght - 1])
        //            {
        //                return false;
        //            }
        //            palindromeLenght--;
        //        }
        //    }
        //    return true;
        //}

    //After pseudo code class: 
    public static bool IsXPalindrome(int x)
        {
            if (x < 0) return false;
            int reverse = 0;
            int temp = x;
            while (temp > 0)
            {
                reverse = reverse * 10 + temp % 10;
                temp = temp / 10;
            }
            return reverse == x;
        }
        //2
        public static int SumAll(int x)
        {
            int digit = 0;
                while (x != 0)
                {
                digit += x % 10;
                x /= 10;
                }
         return digit;
        }
        //3
        public static bool uniqueNumbers(int[] x)
        {
            Dictionary<int, int> result = new();
            foreach (int i in x)
            {
                if (!result.ContainsKey(i))
                {
                    result[i] = 1;
                }
                else if(result.ContainsKey(i))
                {
                    return true;
                }
            }
            return false;
            
        }
    }
}
