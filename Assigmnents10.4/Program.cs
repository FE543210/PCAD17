namespace Assignments10._4ChallengeLabs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testOne = "abcd";
            string testTwo = "abcde";
            FindExtraLetter(testOne, testTwo);
            int[] t1 = [1, 2, 3, 0, 0, 0];
            int[] t2 = [2, 5, 6];
            int m = 3;
            int n = 3;
            Merge(t1, m, t2, n);
            Console.WriteLine($"{String.Join(' ', Merge(t1, m, t2, n))}");//[1,2,2,3,5,6]


        }
        //Solution attempt #1 --> O(n+n) --> O(n)
        public static char FindExtraLetter(string s, string t)
        {
            char result = ' ';
            var StringS = new HashSet<char>(s); //O(n)
            for(int i = 0; i < t.Length; i++) //O(n)
            {
                if (!StringS.Contains(t[i])) // or !(StringS.Add(t[i])) --> Every positive char will return 
                {
                    result = t[i];
                }
            }
            Console.WriteLine(result); //Just to check the answer
            return result;
        }
        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int j = m - 1;
            int c = n - 1;
            int i = m + n - 1;

            while (c >= 0)
            {
                if (j >= 0 && nums1[j] > nums2[c])
                    nums1[i--] = nums1[j--];
                else
                    nums1[i--] = nums2[c--];
            }
            return nums1;
        }
        //Better solution:
        //public static void Merge(int[] nums1, int m, int[] nums2, int n)//O(n)?
        //{
        //    //Leetcode #88
        //    int i = m - 1;  //1
        //    int j = n - 1;     //2   
        //    int c = m + n - 1;    //3
        //    while (i >= 0 && j >= 0)
        //    {
        //        if (nums1[i] > nums2[j])
        //        {
        //            nums1[c--] = nums1[i--];
        //        }
        //        else{
        //         nums1[c--] = nums2[j--];
        //        }
        //    }
        //    while (j >= 0)
        //    {
        //        nums1[c--] = nums2[j--];
        //    }
        //}


    }
}
