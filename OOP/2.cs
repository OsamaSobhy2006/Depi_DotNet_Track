namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1, "Osama", "Sobhy", 10000, 2026);
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

            private decimal CalculateBonus()
            {
                return Salary * 10/100;
            }

            public void PrintEmployee()
            {
                Console.WriteLine("Employee Information");
                Console.WriteLine("---------------------");
                Console.WriteLine($"ID: {Id}");
                Console.WriteLine($"Name: {Fname} {Lname}");
                Console.WriteLine($"Salary: {Salary}");
                Console.WriteLine($"Bonus: {CalculateBonus()}");
                Console.WriteLine($"Total Salary: {Salary + CalculateBonus()}");
                Console.WriteLine($"Hire Year: {HireYear}");
                Console.WriteLine("---------------------");
            }
        }
    }
}
