using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assigment1._4.StudentClass;

namespace Assigment1._4
{
internal class StudentClass
{
    internal class Student
    {
        private int studentId;
        private string studentFname;
        private string studentLname;
        private char studentGrade;

        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public string StudentFname
            {
            get { return studentFname; }
            set { studentFname = value; }
        }
        public string StudentLname
            {
                get { return studentLname; }
                set { studentLname = value; }
            }
        public char StudentGrade
            {
                get { return studentGrade; }
                set { studentGrade = value; }
            }
    }


}
}

