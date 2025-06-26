using System.Text;

namespace Assignment12._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string string1 = "abbaca";
            string string2 = "azxxzy";
            Console.WriteLine(RemoveDuplicates(string1));
            Console.WriteLine(RemoveDuplicates(string2));


        }
        public static string RemoveDuplicates(string s)//
        {
            StringBuilder sb = new();

            foreach (char x in s)
            {
                if (sb.Length > 0 && sb[sb.Length - 1] == x)
                {
                    sb.Length--;
                }
                else
                {
                    sb.Append(x);
                }
            }
            return sb.ToString();
        }
    }
}
