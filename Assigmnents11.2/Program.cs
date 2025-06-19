namespace Assigment11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test1 = [7, 1, 5, 3, 6, 4];//5
            Console.WriteLine(MaxProfit(test1));
            Console.WriteLine("------------------");
            LList test2 = new();
            test2.AddFirst(5);
            test2.AddFirst(4);
            test2.AddFirst(3);
            test2.AddFirst(2);
            test2.AddFirst(1);
            test2.Display();
            Console.WriteLine("------------------");
            test2.Reverse();
            test2.Display();
        }
        //LeetCode #21

        public static int MaxProfit(int[] prices)//O(n)
        {
            if (prices == null || prices.Length < 2)
            {
                return 0;
            }

            int maxProfit = 0;
            int lPointer = 0;
            int RPointer = 1;

            while (RPointer < prices.Length)
            {
                int currentPrice = prices[RPointer];
                int buyPrice = prices[lPointer];

                if (buyPrice < currentPrice)
                {
                    int currentProfit = currentPrice - buyPrice;
                    maxProfit = Math.Max(maxProfit, currentProfit);
                }
                else
                {
                    lPointer = RPointer;
                }

                RPointer++;
            }

            return maxProfit;
        }


    }
}
