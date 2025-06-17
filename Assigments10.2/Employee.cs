using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments10._2
{
    public class Employee
    {
        public String Name { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
        public Employee(string name, int salary, int age)
        {
            this.Name = name;
            this.Salary = salary;
            this.Age = age;
        }

    }
}
