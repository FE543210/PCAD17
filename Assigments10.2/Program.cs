namespace Assignments10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1
            List<int> testOne = new List<int> { 2, -1, 3, -3, 10, -200 };
            var resultOne = Querries.GetPositiveNumbers(testOne);
            foreach(int x in resultOne)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("---------------------");
            //2
            List<Employee> empList = new List<Employee>
            {
                new Employee("Johnathan", 6000, 25),
                new Employee("John", 5000, 31),
                new Employee("Johnie", 5001, 29),
                new Employee("Johniel",4999, 29),
                new Employee("JohnTaniel", 5000, 30),
                new Employee("Jack", 6000, 32),
            };
            var resultTwo = Querries.GetEmployes(empList);
            foreach (string x in resultTwo)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("---------------------");
            //3
            String[] testThree = new String[] { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            Querries.GetCities('A', 'M', testThree);
            Console.WriteLine("---------------------");
            //4
            List<int> resultFour = new List<int> { 55, 200, 740, 76, 230, 482, 95 };
            Querries.PrintNumsList(resultFour);

        }
    }
}
