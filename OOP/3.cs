using System.Dynamic;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1, "Osama", "Sobhy", 10000, 2022);
            emp1.PrintEmployee();

        }
        class Employee
        {
            public int Id;
            public string Fname;
            public string Lname;
            public decimal Salary;
            public int HireYear;

            public Employee(int id, string fname, string lname, decimal salary, int hireYear)
            {
                Id = id;
                Fname = fname;
                Lname = lname;
                Salary = salary;
                HireYear = hireYear;
            }

            private int getYearsOfExperience()
            {
                return DateTime.Now.Year - HireYear;
            }

            public void PrintEmployee()
            {
                Console.WriteLine($"Name: {Fname} {Lname}");
                Console.WriteLine($"Salary: {Salary}");
                Console.WriteLine($"Years Of Experience: {getYearsOfExperience()}");
            }
        }
    }
}
