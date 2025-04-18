using System.ComponentModel;
using System.Runtime;
using System.Xml.Linq;

//1.Write a program in C# Sharp to find the sum of all array elements.
//Input the number of elements to be stored in the array :3


Console.WriteLine("How many elements to be stored in the array?");
int arraySize= Convert.ToInt32(Console.ReadLine());

double[] arrayForSum = new double[arraySize];
double currentArray = 0;
double totalArraySum = 0;

for (int i=0; i<arraySize; i++)
{
    Console.WriteLine($"Input array element #{i}: ");
    currentArray = Convert.ToDouble(Console.ReadLine());
    arrayForSum[i] = currentArray;
    totalArraySum += currentArray;
}
Console.WriteLine($"Your array is composed of {string.Join(", ", arrayForSum)} and the sum of all elements stored is : {totalArraySum}");

//2.Write a C# Sharp program to find the largest of three numbers.
double largestOfThree = double.MinValue; // That way I can scale this loop without having to repeat the code block from inside the loop.
double numberBeingCompared;
Console.WriteLine("Input");
for(int i=0; i<3; i++)
{
    Console.WriteLine($"Input #{i+1}");
    numberBeingCompared = Convert.ToDouble(Console.ReadLine());  
    largestOfThree = (numberBeingCompared > largestOfThree) ? numberBeingCompared : largestOfThree;

}
Console.WriteLine($"The largest # from the list was:{largestOfThree}.");

//3.Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
//Adress 3 outliers,  can use switch, nested or just if/else

Console.WriteLine("What is your x cordinate:");
double xCord = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is your y cordinate:");
double yCord = Convert.ToDouble(Console.ReadLine());

if (xCord == 0 && yCord == 0)
{
    Console.WriteLine("Point is at the origin");
}
else if (xCord == 0  )
{
    Console.WriteLine("The point is at the X-Axis");
}
else if(yCord == 0)
{
    Console.WriteLine("The point is at the Y-Axis");
}
else if (xCord > 0 && yCord > 0)
{
    Console.WriteLine("The point is at the first quadrant");
}
else if(xCord < 0 && yCord > 0)
{
    Console.WriteLine("The point is at the second quadrant");
}
else if(xCord < 0 && yCord < 0)
{
    Console.WriteLine("The point is at the third quadrant");
}
else
{
    Console.WriteLine("The point is at the fourth quadrant");
}





