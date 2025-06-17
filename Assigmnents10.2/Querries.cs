using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments10._2
{
    public class Querries
    {
        //10.2.1
        public static List<int> GetPositiveNumbers(List<int> nums) {
            return (from num in nums
                    where num > 0
                    select num).ToList();
        }
        //10.2.2
        public static string[] GetEmployes(List<Employee> employees) {
            return  (from employee in employees
                     where employee.Salary > 5000 && employee.Age < 30
                     select employee.Name).ToArray();
        }
        //10.2.3
        public static void GetCities(Char start, char end, string[] cities)
        {
            string result = (from city in cities
                             where city.StartsWith(start.ToString()) && city.EndsWith(end.ToString())
                         select city).FirstOrDefault();
            if (result != null) {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("City not found!");
            }
        }
        //10.2.4
        public static void PrintNumsList(List<int> nums)
        {
            int[] numsToPrint = (from num in nums
                                 where num > 80
                                 select num).ToArray();
            foreach (int x in numsToPrint)
            {
                Console.WriteLine(x);
            }
        }
    }
}
