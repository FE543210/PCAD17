//1.Create a 2D array to store integers and print them in matrix format with proper formatting.
using System.ComponentModel;

int[,] tables = { { 2, 3, 4 }, { 1, 4, 6 }, { 3, 4, 5 } };
int row = tables.GetLength(0);
int col = tables.GetLength(1);

for (int i = 0; i < row; i++)
{
    Console.Write("|");
    for (int j = 0; j < col; j++)
    {
        Console.Write($"{tables[i, j]}|");
    }
    Console.WriteLine("\n");
}

//2
int[,] firstMatrice = {
                        {1, 2 },
                        { 3, 4 }
                      };
int[,] secondMatrice = {
                        {5, 6 },
                        { 7, 8 }
                      };
Console.WriteLine($"The First matrix is:");
DisplayMatrices(firstMatrice);
Console.WriteLine($"The Second matrix is:");
DisplayMatrices(secondMatrice);
Console.WriteLine($"The Addition of two matrix is:");
AddThenDisplayMatrices(firstMatrice, secondMatrice);
//4
List<int> allTheNumbers = new();
for (int i = 1; i <= 4; i++)
{
    Console.WriteLine($"Enter input number #{i}");
    int input = Convert.ToInt32(Console.ReadLine());
    allTheNumbers.Add(input);
}
List<double> avgSum = new();
avgSum = GetSumAndAvg(allTheNumbers.ToArray());
Console.WriteLine($"The total sum of {string.Join(",", allTheNumbers)} is {avgSum[0]}");
Console.WriteLine($"The average is: {avgSum[1]}");
//5
int[] testArr1 = {1,2,3,4,5};
Console.WriteLine($"Target 5: {Index(testArr1,5)}");
Console.WriteLine($"Target 6: {Index(testArr1, 6)}");
//1
void DisplayMatrices(int[,] x)
{
    int row = x.GetLength(0);
    int col = x.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{x[i, j]} ");
        }
        Console.WriteLine("\n");
    }
}
//2
void AddThenDisplayMatrices(int[,] x, int[,] y)
{
    int row = x.GetLength(0);
    int col = x.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{x[i, j] + y[i, j]} ");
        }
        Console.WriteLine("\n");
    }
}

//4. Write a function that takes 4 numbers as input to calculate the total and average.
//(Make use of params array to pass arguments and out parameters to return both total and average to main method).
List<double> GetSumAndAvg(int[] nums)
{
    int totalSum = 0;
    foreach (int num in nums) { 
        totalSum += num;
    }
    double totalAverage = totalSum/nums.Length;
    return new List<double> { totalSum, totalAverage};
}

//5 Create a function that finds the index of a given item in the array
int Index(int[] arr,int target)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == target) return i;
    }
    return -1;
}

