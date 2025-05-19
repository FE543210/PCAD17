using System.Numerics;

namespace Assignments6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] testOne = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Rotate(testOne);
            for(int i = 0; i< testOne.GetLength(0); i++)
            {
                for(int x = 0; x < testOne.GetLength(0); x++)
                {
                    Console.Write(testOne[i,x] + " ");

                }
                Console.WriteLine();
            }
        }

        public static void Rotate(int[,] matrix)
        {
            //    ///Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
            //    //Output: [[7, 4, 1],[8, 5, 2],[9, 6, 3]]
            int matrixRow = matrix.GetLength(0);
            if (matrixRow < 1) { return; }

            for(int i=0; i<matrixRow; i++)
            {
                for(int x = i +1; x < matrixRow; x++)
                {
                    int temp = matrix[i, x];
                    matrix[i, x] = matrix[x, i];
                    matrix[x, i] = temp;
                    //3 Way switch
                    //[1,4,7]
                    //[2,5,8]
                    //[3,6,9]
                }
            }
            for(int i = 0; i <matrixRow; i++)
            {
                for (int x = 0; x < matrixRow/2; x++)
                {
                    int temp = matrix[i, x];
                    matrix[i, x] = matrix[i, matrixRow - x - 1];
                    matrix[i, matrixRow - x - 1] = temp;
                }
                
            }
            //[7, 4, 1]
            //[8, 5, 2]
            //[9, 6, 3]]
            //No need to return, matrix is reff type
        }

    }
}
