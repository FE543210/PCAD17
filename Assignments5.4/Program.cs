namespace Assignments5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            SpaceOutDigits(1234);
            Console.WriteLine();
            //2
            Console.WriteLine("What is the size of the matrix?");
            int matrixSize = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.WriteLine($"Element - [{i}], [{j}]");
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine($"Addition of the right Diagonal elements is: {MatrixSum(matrix)}");
        }
        static void SpaceOutDigits(int n)
        {
            if(n < 10)
            {
                Console.Write(n + " ");
            }
            else
            {
                SpaceOutDigits(n / 10);
                Console.Write(n % 10 + " ");
            }
        }
        static int MatrixSum(int[,] matrix){
            int maxLength = matrix.GetLength(0);
            int total = 0;
            for (int i = 0; i < maxLength; i++)
            {
                total += matrix[i, maxLength - 1 - i];
            }
            return total;
        }

    }
}
