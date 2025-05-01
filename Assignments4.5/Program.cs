//1.If number contains 3
//Write a method that checks if given number (positive integer) contains digit 3. Do not convert number to other type.
//Do not use built-in functions like Contains(), StartsWith(), etc.
Console.WriteLine(123 / 10);
Console.WriteLine(12 / 10);
Console.WriteLine(1 / 10);

Console.WriteLine($"{Contains3(7201432)}");
Console.WriteLine($"{Contains3(584848484)}");
Console.WriteLine($"{Contains3(12456789)}");
bool Contains3(int x)
{
    while (x != 0)
    {
        if(x % 10 == 3)
        {
            return true;
        }
        x /= 10;
    }
    return false;
}

//2 . Divisible by 2 or 3
//Given two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, otherwise returns their sum.
//Expected input and output

int AddOrMutiply(int x, int y)
{
    if((x% 2 == 0 || x % 3 == 0) && (y% 2 == 0 || y % 3 == 0))
    {
        return x * y;
    }
    return x + y;
}

//3. Write a function that reverses a string. The input string is given as an array of characters s.
//You must do this by modifying the input array in-place. (Problem 344 in leetcode)
char[] example1 = ['H', 'E', 'L', 'L', 'O'];
Console.WriteLine($"{stringReverseAgain(example1)}");


void stringReverseAgain(char[] s)
{

    //for (int x = 0; x < s.Length/2; x++) { }
    int left = 0;
    int right = s.Length - 1;
    while (left < right)
    {
        char x = s[left];
        s[left] = s[right];
        s[left] = x;

        left++;
        right--;
    }
}
