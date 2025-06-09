using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments10._1
{
    public class Students
    {
        public string StudentID { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public double StudentGPA { get; set; }

        public Students() { }
        public Students(string studentID, string studentFirstName, string studentLastName, double studentGPA)
        {
            StudentID = studentID;
            StudentFirstName = studentFirstName;
            StudentLastName = studentLastName;
            StudentGPA = studentGPA;
        }
    }
}
