namespace Assignments11._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testOne = { 40, 10, 20, 30 };
            Console.WriteLine(String.Join(' ', Transform(testOne)));
            int[] testTwo = { 3, 2, 3 };
            Console.WriteLine(MajorityElement(testTwo));

        }
        public static int[] Transform(int[] arr)
        {
            Dictionary<int, int> rank = new();
            int[] copy = new int[arr.Length];
            Array.Copy(arr, copy, arr.Length);
            Array.Sort(copy);

            int currentRank = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                int val = copy[i];
                if (!rank.ContainsKey(val)) rank[val] = currentRank++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rank[arr[i]];
            }
            return arr;
        }
        public static int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!dict.ContainsKey(num))
                    dict.Add(num, 1);
                else
                    dict[num] += 1;
            }
            int biggest = dict.Values.Max();
            return dict.First(x => x.Value == biggest).Key;
        }
    }
}
