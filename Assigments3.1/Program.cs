using System.Text;

////1
//Console.WriteLine("Pick a number greater than 0 and less than 100: ");
//int numBeingParsed = Convert.ToInt32(Console.ReadLine());
//if (numBeingParsed < 0 || numBeingParsed > 100)
//{
//    numBeingParsed = 100;
//}
//Console.WriteLine(returnEvenNumbers(numBeingParsed));

////2
//Console.WriteLine("Input year chossen to see if it is leap year: ");
//int YearChosen = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(isYearLeap(YearChosen));

////3
//Console.WriteLine("Enter your string: ");
//string spacesTotalCount = Console.ReadLine();
//Console.WriteLine($"\"{spacesTotalCount}\" contains {countSpaces(spacesTotalCount)} spaces.");

//4
int[] sunshine = [0, 1, 2, 3, 4, 1, 1, 7, 1, 1, 10, 11, 11, 1, 1, 2 , 3];
Console.WriteLine($"{String.Join(",",sunshine)}");
arrayValues(sunshine);
Console.WriteLine($"{String.Join(",", sunshine)}");

//1
static StringBuilder returnEvenNumbers(int maxNumber)
{
    StringBuilder evenNumbers = new();
    for (int i = 2; i < maxNumber; i += 2)
    {
            evenNumbers.Append(Convert.ToString(i) + " ");
    }
    return evenNumbers;
}
//2 DateTime.IsLeapYear(Int32) is also an option
bool isYearLeap(int year)
{
    if (year % 400 == 0)
    {
        return true;
    }
    else if (year % 100 == 0)
    {
        return false;
    }
    else if (year % 4 ==0) {
        return true;
    }
    else { 
        return false;
    }
}

//3 
int countSpaces(string spacesTotalCount)
{
    int totalCount = 0;
    foreach (char x in spacesTotalCount)
    {
        if (x == ' ')
        {
            totalCount++;
        }
    }
    return totalCount;
}

//4
void arrayValues(int[] arrayOfSunshine)
{

    for(int i=0; i <arrayOfSunshine.Length - 2; i++){
        if (arrayOfSunshine[i] == arrayOfSunshine[i+1] && arrayOfSunshine[i] == 1)
        {
            arrayOfSunshine[i] = 0;
            arrayOfSunshine[i+1] = 0;
            break;
        }
    }
}