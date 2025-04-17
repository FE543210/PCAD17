//Problem One
//using System.IO;
const string filePath = ".\\newFileTest.txt";
//Console.WriteLine("Show the path: " + Path.GetFullPath(filePath));
string nameAge;
try
{
    StreamWriter sw = new StreamWriter(filePath);
    //It creates a new file if file ios not there!
    sw.WriteLine("Filipe");
    sw.WriteLine("I am 104 years olds");
    sw.Close();
}
catch(Exception e)
{
    Console.WriteLine("Failed, exception " + e.Message);

}
finally
{
    Console.WriteLine("Executed finally block");
}

try
{
    StreamReader sr = new StreamReader(filePath);
    nameAge = sr.ReadLine();
    while(nameAge != null)
    {
        Console.WriteLine(nameAge);
        nameAge = sr.ReadLine();
    }
    sr.Close();
    //Console.ReadLine(); Not needed in current debug mode but otherwise console would just flash open
}
catch(Exception e)
{
    Console.WriteLine("Failed, exception " + e.Message);
}
finally
{
    Console.WriteLine("Executed finally block");
}

//Design a tip Calculator
Console.WriteLine("Enter bill total : ");
double billBeforeTip = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter selected tip %");
double tipPercent = Convert.ToDouble(Console.ReadLine());
tipPercent = tipPercent / 100;
double billAfterTip = billBeforeTip + (billBeforeTip * tipPercent);
Console.WriteLine($"Bill Before Tip: {billBeforeTip:C}");
Console.WriteLine($"Tip selected: {tipPercent:P}");
Console.WriteLine($"Your total after tip is {billAfterTip:C}.");