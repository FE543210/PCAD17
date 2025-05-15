namespace Assignments6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] testOne = new int[][]
            {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
            };
            int[][] testTwo = new int[][]
            {
            new int[] {5, 1, 9,11},
            new int[] {2, 4, 8,10},
            new int[] {13, 3, 6,7},
            new int[] {15,14,12,16}
            };
            Rotate(testOne);
            Console.WriteLine();
            Rotate(testTwo);
        }
        //Leetcode #48
        public static void Rotate(int[][] matrix)
        {
            ///Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
            //Output: [[7, 4, 1],[8, 5, 2],[9, 6, 3]]
            int temp = 0;
            for (int j = 0; j <= matrix.Length - 1; j++)
            {
                for (int i = matrix.Length - 1; i >= 0; i--)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }


        }
        
    }
}
