//using System.ComponentModel;
////1. Write C# program to accept two integers and check if they are equal or not.
//Console.WriteLine("Input 1st number: ");
//int firstNumber = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input 2nd number: ");
//int secondNumber = Convert.ToInt32(Console.ReadLine());
//if (firstNumber == secondNumber)
//{
//    Console.WriteLine($"{firstNumber} and {secondNumber} are equal\n");
//}
//else{
//    Console.WriteLine($"{firstNumber} and {secondNumber} are not equal\n");
//}
////2. Write a C# Sharp program to find the sum of first 10 natural numbers.
//int totalSum = 0;
//for (int i = 1; i < 11; i++)
//{
//    Console.Write($"{i} ");
//    totalSum += i;
//}
//Console.WriteLine($"\nThe total sum of the first 10 natural numbers is {totalSum}.");
////Write a menu driven application to perform calculation functions like
////addition, subtraction, multiplication, and division.

char repeatOption;
do
{
    double resultTotal;
    Console.WriteLine("Welcome to the simple calculator");
    Console.WriteLine("Enter your first number");
    double firstCalculatorNumber = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter your second number");
    double secondCalulatorNumber = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Choose your operator: \"+,-,x, /,\"");
    char arithmeticOperator = Convert.ToChar(Console.ReadLine());

    switch (arithmeticOperator)
    {
        case '+':
            CalculatorDisplay(Add(firstCalculatorNumber, secondCalulatorNumber));
            break;
        case '-':
            CalculatorDisplay(Subtract(firstCalculatorNumber, secondCalulatorNumber));
            break;
        case 'x':
            CalculatorDisplay(Mutiply(firstCalculatorNumber, secondCalulatorNumber));
            break;
        case '/':
            CalculatorDisplay(Divide(firstCalculatorNumber, secondCalulatorNumber));
            break;
        default:
            Console.WriteLine("Invalid Operator Choice");
            break;
    }
    Console.WriteLine("Type Y to re-use calculator or press any other key to exit");
    repeatOption = Convert.ToChar((Console.ReadLine()));
} while (repeatOption == 'Y');


//Methods:
static double Add(double x, double y)
{
    return x + y;
}
static double Mutiply(double x, double y)
{
    return x * y;
}
static double Subtract(double x, double y)
{
    return x - y;
}
static double Divide(double x, double y)
{
    if (y == 0)
    {
        Console.WriteLine("Cannot divide by 0!");
        return double.NaN;
    }
    else
    {
        return x / y;
    }
}
static void CalculatorDisplay(double z)
{
    Console.WriteLine($"Result: {z}");
}
