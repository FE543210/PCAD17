using System.Net;
//1.Create a console application in C# to store and print personal details of a person like
//name, age and address on console screen. Make use of appropriate variables.
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("How old are you?");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is your adress?");
string address = Console.ReadLine();
Console.WriteLine($"\n{name}, you are {age} years old and live at: {address}\n\n");

//2. Write a C# program to print the sum of two numbers. Get the input from user.
Console.WriteLine("What is the first number being added?");
double sumOne = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is the second number being added?");
double sumTwo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Total Sum: " + (sumOne + sumTwo) +"\n\n");

//3. Write a C# program to print the result of dividing two numbers. Print the quotient and remainder as well. Get the input from the user.
Console.WriteLine("Choose your numerator: ");
double numerator = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Chosse your denominator: ");
double denomitator = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{numerator} / {denomitator} = {(numerator / denomitator)} with a remmainder of: {(numerator % denomitator)}");


