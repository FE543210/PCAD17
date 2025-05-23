using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments7._2
{
    internal class Anagram
    {
        public static bool Nagaram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            Dictionary<char, int> frequency = new();
            foreach( char x in s)
            {
                if (!frequency.ContainsKey(x)) { frequency[x] = 0; }
                frequency[x]++;
            }
            //The actual check
            foreach (char x in t)
            {
                if (!frequency.ContainsKey(x) || frequency[x] == 0) { frequency[x] = 0; }
                frequency[x]++;
            }
            return true;
        }
    }
}
