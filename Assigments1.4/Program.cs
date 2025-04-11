using static Assigment1._4.StudentClass;

namespace Assigment1._4
{
    class Point
    {
        public double X, Y;

        public void PointCompare(double pointBeingCompared)
        {
            if (X > pointBeingCompared)
            {
                Console.WriteLine("Point 2 is to the left of Point 1.");
            }
            else if (X < pointBeingCompared)
            {
                Console.WriteLine("Point 2 is to the right of Point 2");
            }
            else
            {
                Console.WriteLine("Both points share the same vertical axis.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point P1 = new Point { X = 15, Y = 20 };
            Point P2 = new Point { X = 5, Y = 40};
            P1.PointCompare(P2.X);

            StudentClass.Student studentOne = new Student();
            studentOne.StudentId = 145;
            studentOne.StudentFname = "Filipe";
            studentOne.StudentLname = "Reis";
            studentOne.StudentGrade = 'A';
            System.Console.WriteLine($"Student with an Student ID: {studentOne.StudentId}, named {studentOne.StudentFname} {studentOne.StudentLname} has a grade of {studentOne.StudentGrade}");
        }
    }

}
