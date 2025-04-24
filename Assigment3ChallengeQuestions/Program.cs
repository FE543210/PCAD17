using System.Text;
//1:
Console.Write("Is your string a Palindrome?: ");
string maybePalindrome = Console.ReadLine();
Console.WriteLine($"String Palindrome: {isPalindrome(removeCharacters(maybePalindrome))}");

//2 
Console.Write("Input your string: ");
string mightySum = Console.ReadLine();
Console.WriteLine($"Total sum for the numbers in the string is: {sumDigits(mightySum)}");

//3
int[] ints = { 1, 5, 3, 8, 6, 7, 8, 9, 10, 11 };
Console.WriteLine($"What is your targert number? ");
int target = Convert.ToInt32(Console.ReadLine());
int[] result = sums(ints, target);
if (result[0] == -1)
{
    Console.WriteLine($"There is no numbers that add up to the target");
}
else
{
    Console.WriteLine($"The numbers at index {result[0]} and {result[1]} add up to the target: {target}");
}

//4
Console.WriteLine(minLenght("ABFCACDB")); //Should return 2
Console.WriteLine(minLenght("ABFCACDBABFCACDB")); //Should return 4
Console.WriteLine(minLenght("")); //Should return 0


//Regex.Replace(maybePalindrome.ToLower(), @"[^a-z0-9]", "");   <-- Easier way?
string removeCharacters(string needsCleaning)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char x in needsCleaning)
        {
            if (x != ' ' && x != ',' && x != '.' && x != ';' && x != ':')
            {
                sb.Append(x);
            }

        }
        return sb.ToString();
    }
bool isPalindrome(string stringParsed)
{
    for (int i = 0; i < stringParsed.Length/2; i++)
    {
        if (stringParsed[i] != stringParsed[stringParsed.Length - 1])
        {
            return false;
        }
    }
    return true;
}
//2:
//string[] nums = ["1", "2", ""]; Hashset? collection of unique items with fast look up, inserts and deletions
int sumDigits(string sumsString)
{
    HashSet<char> nums = new() {'1', '2', '3', '4', '5', '6', '7', '8', '9' };
    int totalSum = 0;
    foreach (char x in sumsString)
    {
        if (nums.Contains(x))
        {
            //'3' - '0' == 51 - 48 == 3 character digit conversion
            totalSum += x - '0';
        }
    }
    return totalSum;
}
//3 
int[] sums(int[] numArray, int targetNum)
{
    for (int i = 0; i < numArray.Length - 1; i++)
    {
        for (int j = 1+i; j<numArray.Length; j++)
        {
            if (numArray[i] + numArray[j] == targetNum) return new int[] {i,j};
        }
    }
    return new int[] {-1};
}
//4
int minLenght(string x)
{
    bool flipString;
    do { 
        flipString = false;
        string before = x;
        x = x.Replace("AB", "");
        x = x.Replace("CD", "");
        if (x != before)
        {
            flipString = true;
        }
    } while (flipString);
    return x.Length;
}