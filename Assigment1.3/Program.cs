////3.Write a program in C# to calculate area of triangle, square and rectangle. 
////Write 2 or 3 different functions for each shape to take dimensions of figure and display the area. 
////You may create menus.
//bool exitCalculator = false;
//Console.WriteLine("Welcome to the area calculator");

//do
//{   
//    Console.WriteLine("Choose your shape\n\t\"s\": for square\n\t\"r\": for rectangle\n\t\"t\":for triangle\n\t\"q\":to quit the program");
//    char choice = Convert.ToChar(Console.ReadLine());
//    double lenghtOrBase, height;
//    switch (choice)
//    {
//        case 's':
//            Console.WriteLine("Enter base:");
//            lenghtOrBase = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine(Rectangles(lenghtOrBase, lenghtOrBase));
//            break;
//        case 'r':
//            Console.WriteLine("Enter width: ");
//            lenghtOrBase = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Enter height:"); ;
//            height = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine(Rectangles(lenghtOrBase, height));
//            break;
//        case 't':
//            Console.WriteLine("Enter lenght or base:");
//            lenghtOrBase = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Enter height:"); ;
//            height = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine(Triangles(lenghtOrBase, height));
//            break;
//        case 'q':
//            exitCalculator = true;
//            break;
//        default:
//            Console.WriteLine("Invalid Choice, please choose again");
//            break;
//    }
//} while (exitCalculator == false);
//static string Rectangles(double lenghtOrBase, double height)
//{
//    return $"Area: {lenghtOrBase * height} units²";
//}
//static string Triangles(double triangleBase, double triangleHeight)
//{
//    return $"Area: {(0.5*triangleBase*triangleHeight)} units²";
//}


//2.Write a console application in C#
//to explore different ways in which array is declared and initialized and explore 
//different properties and methods of Array class.
//Just see w3 page on arrays.


//3.Write a program in C# 
//to read n number of values in an array and display it in reverse order.

int placeHolder;
int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine(string.Join(", ", myArray));

for (int x = 0; x < myArray.Length / 2; x++)
{
    placeHolder = myArray[x];
    myArray[x] = myArray[myArray.Length - 1 - x];
    myArray[myArray.Length - 1 - x] = placeHolder;
}

Console.WriteLine(string.Join(", ", myArray));

//int[] myArrayTwo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//ReverseMyArray(myArrayTwo);
//static void ReverseMyArray(int[] myArray)
//{
//    int placeHolder;
//    Console.WriteLine(string.Join(", ", myArray));

//    for (int x = 0; x < myArray.Length / 2; x++)
//    {
//        placeHolder = myArray[x];
//        myArray[x] = myArray[myArray.Length - 1 - x];
//        myArray[myArray.Length - 1 - x] = placeHolder;
//    }
//    Console.WriteLine(string.Join(", ", myArray));
//}

// Extra Assigment:
