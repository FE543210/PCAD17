namespace Asssigments12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test1s = "a";
            string test1b = "b";
            string test2s = "aa";
            string test2b = "ab";
            string test3s = "aa";
            string test3b = "aab";
            Console.WriteLine(RansomNoteVerification(test1s,test1b));
            Console.WriteLine(RansomNoteVerification(test2s, test2b));
            Console.WriteLine(RansomNoteVerification(test3s, test3b));

            LList testTwo = new();
            testTwo.AddFirst(1);
            testTwo.AddFirst(2);
            testTwo.AddFirst(2);
            testTwo.AddFirst(1);

            LList testTwo2 = new();
            testTwo2.AddFirst(1);
            testTwo2.AddFirst(2);
            testTwo2.AddFirst(3);

            Console.WriteLine(testTwo.IsPalindrome());
            Console.WriteLine(testTwo2.IsPalindrome());




        }
        public static bool RansomNoteVerification(string ransomNote, string magazine)//O(n)
        {
            Dictionary<char, int> countLetter = new Dictionary<char, int>();//O(n)
            foreach (char x in magazine)//O(n)
            {
                if (countLetter.ContainsKey(x))
                {
                    countLetter[x]++;
                }
                else
                {
                    countLetter[x] = 1;
                }
            }
            foreach (char x in ransomNote)//O(n)
            {
                if (!countLetter.ContainsKey(x) || countLetter[x] == 0)
                {
                    return false;
                }
                countLetter[x]--;
            }
            return true;
        }
    }
}
