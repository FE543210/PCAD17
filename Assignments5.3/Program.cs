namespace Assignments5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine(adjacentPlot([1,0,0,0,1], 1));
            Console.WriteLine(adjacentPlot([1, 0, 0, 0, 1], 2));
            Console.WriteLine(adjacentPlot([1, 0, 1, 0, 1], 1));
            //2
            Console.WriteLine(ClimbingCount(1));
            Console.WriteLine(ClimbingCount(3));
            Console.WriteLine(ClimbingCount(5));
        }
        //1
        public static bool adjacentPlot(int[] gardenBed, int newFlowers)
        {
            int flowerSpots = 0;
            for (int i = 0; i < gardenBed.Length; i++)
            {
                if (gardenBed[i] == 0)
                {
                    bool left = (i == 0) || gardenBed[i - 1] == 0;
                    bool right = (i == gardenBed.Length - 1) || gardenBed[i + 1] == 0;
                    if (left && right)
                    {
                        gardenBed[i] = 1;
                        flowerSpots++;
                        i++;
                    }
                }
            }
            return flowerSpots >= newFlowers;
        }
        //2 Fibonacci sequence?
        public static int ClimbingCount(int x)
        {
            if (x <= 2) return x;
            int y = 1;
            int z = 2;
            for (int i = 0; i < x; i++)
            {
                int placeHolder = y + z;
                x = y;
                y = placeHolder;
            }
            return y;
        }
    }
}
