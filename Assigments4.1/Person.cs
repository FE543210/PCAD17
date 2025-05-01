using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment4._1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string WorPhone { get; set; }
        public string Address { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
