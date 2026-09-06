#region Task 1
namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HireDate hireDate = new HireDate(5, 9, 2026);
            Topic topic1 = new Topic(1, "C# Basics");
            Topic topic2 = new Topic { Id = 2, Name = "Datebase", EntityName = nameof(Topic) };

            Course course1 = new Course
                (1, "C# Fundamentals", 30, "Learn C# fundamentals", topic1.Id);

            Course course2 = new Course
                (2, "SQL & Entity Framework", 40, "Learn SQL and Entity Framework", topic2.Id);

            topic1.Print();
            Console.WriteLine();
            topic2.Print();
            Console.WriteLine();
            course1.Print();
            Console.WriteLine();
            course2.Print();
        }
        struct HireDate
        {
            public int Day;
            public int Month;
            public int Year;

            public HireDate(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }
        }

        class BaseEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
            internal string EntityName { get; set;}

            public BaseEntity() { }
            public BaseEntity(int id, string name)
            {
                Id = id;
                Name = name;
            }
            public virtual void Print()
            {
                Console.WriteLine($"Entity Name: {EntityName}");
                Console.WriteLine($"Id: {Id}");
                Console.WriteLine($"Name: {Name}");
            }
        }
        class Topic : BaseEntity
        {
            public Topic() { }
            public Topic(int id, string name) : base(id, name)
            {
                EntityName = nameof(Topic);
            }
            public override void Print()
            {
                Console.WriteLine("Topic Information");
                Console.WriteLine("-------------------");
                base.Print();
                Console.WriteLine("-------------------");
            }
        }
        class BaseEntityWithCreateDate : BaseEntity
        {
            public DateTime CreateDate { get; set; }

            public BaseEntityWithCreateDate(int id, string name) : base(id, name)
            {
                CreateDate = DateTime.Now;
            }
        }
        class Course: BaseEntityWithCreateDate
        {
            public int Duration { get; set; }
            public string Description { get; set; }
            public int TopicId { get; set; }

            public Course(int id, 
                string name, int duration, 
                string descirption, int topicId)
                : base(id, name)
            {
                Duration = duration;    
                Description = descirption;
                TopicId = topicId;
                EntityName = nameof(Course);
            }

            public override void Print()
            {
                Console.WriteLine("Course Information");
                Console.WriteLine("---------------------");
                base.Print();
                Console.WriteLine($"Duration: {Duration}");
                Console.WriteLine($"Description: {Description}");
                Console.WriteLine($"Topic Id: {TopicId}");
                Console.WriteLine("---------------------");
            }
        }
    }
}
#endregion

#region Task 2
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
#endregion

#region Task 3
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
#endregion

#region Task 4
namespace _4
{
    internal class Program
    {
        public struct HireDate
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }
            public HireDate(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }
            public void PrintDate()
            {
                Console.WriteLine($"Date: {Day}/{Month}/{Year}");
            }
        }
        static void Main(string[] args)
        {
            HireDate date1 = new HireDate(5, 9, 2026);
            Console.WriteLine("Original Date: ");
            date1.PrintDate();
            Console.WriteLine("-----------------------");

            HireDate date2 = date1;
            date2.Day = 2;
            date2.Month = 2;
            date2.Year = 2025;

            Console.WriteLine("After Modifing the Copy: ");

            Console.WriteLine("Original Date:");
            date1.PrintDate();

            Console.WriteLine("Copied Date:");
            date2.PrintDate();
            

            // and this happen because Struct is Value Type
        }
    }
}

#endregion

#region Task 5
namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Topic topic = new Topic()
            {
                Id = 1,
                Name = "Osama"
            };
            Course course = new Course()
            {
                Id = 2,
                Name = "Sobhy"
            };

            Console.WriteLine("Topic");
            Console.WriteLine($"Id: {topic.Id}");
            Console.WriteLine($"Name: {topic.Name}");

            Console.WriteLine("Course");
            Console.WriteLine($"Id: {course.Id}");
            Console.WriteLine($"Name: {course.Name}");
        }

        class BaseEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        class Topic : BaseEntity{}
        class Course: BaseEntity{}
    }
}

#endregion

#region Task 6
namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course()
            {
                Id = 2,
                Name = "Full Stack .NET",
                CreateDate = DateTime.Now,
                Duration = 3,
                Description = "Description",
                topicId = 2
            };

            Console.WriteLine("Course");
            Console.WriteLine($"Id: {course.Id}");
            Console.WriteLine($"Name: {course.Name}");
            Console.WriteLine($"CreateDate: {course.CreateDate}");
            Console.WriteLine($"Duration: {course.Duration}");
            Console.WriteLine($"Description: {course.Description}");
            Console.WriteLine($"Topic Id: {course.topicId}");
        }

        class BaseEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        class BaseEntityWithCreateDate : BaseEntity
        {
            public DateTime CreateDate { get; set; }
        }
        class Course : BaseEntityWithCreateDate 
        {
            public int Duration { get; set; }
            public string Description { get; set; }
            public int topicId { get; set; }
        }
    }
}

#endregion

#region Task 7
namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Topic topic = new Topic { Id = 1, Name = "Osama" };
            topic.Print();

            Course course = new Course()
            {
                Id = 1,
                Name = "Full Stack .NET",
                Duration = 12,
                Description = "Some Description",
                topicId = topic.Id
            };
            course.Print();
        }

        class BaseEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public virtual void Print()
            {
                Console.WriteLine($"Id: {Id}");
                Console.WriteLine($"Name: {Name}");
            }
        }

        class Topic : BaseEntity
        {
            public override void Print()
            {
                Console.WriteLine("Topic Information");
                Console.WriteLine("------------------");
                base.Print();
                Console.WriteLine("------------------");
            }
        }

        class Course : BaseEntity
        {
            public int Duration { get; set; }
            public string Description { get; set; }
            public int topicId { get; set; }
            public override void Print()
            {
                Console.WriteLine("Course Information");
                Console.WriteLine("---------------------");
                base.Print();
                Console.WriteLine($"Duration: {Duration}");
                Console.WriteLine($"Description: {Description}");
                Console.WriteLine($"Topic Id: {topicId}");
                Console.WriteLine("----------------------");
            }
        }
    }
}
#endregion

#region Task 8
namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseEntity entity1 = new Topic { Id = 1, Name = "Osama" };

            BaseEntity entity2 = new Course()
            {
                Id = 1,
                Name = "Full Stack .NET",
                Duration = 12,
                Description = "Some Description",
                topicId = 1
            };

            // entity1 is a BaseEntity reference, but it points to a topic object.
            // Because Print() is overridden, the topic's Print() method is called
            entity1.Print();
            entity2.Print();
        }

        class BaseEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public virtual void Print()
            {
                Console.WriteLine($"Id: {Id}");
                Console.WriteLine($"Name: {Name}");
            }
        }

        class Topic : BaseEntity
        {
            public override void Print()
            {
                Console.WriteLine("Topic Information");
                Console.WriteLine("------------------");
                base.Print();
                Console.WriteLine("------------------");
            }
        }

        class Course : BaseEntity
        {
            public int Duration { get; set; }
            public string Description { get; set; }
            public int topicId { get; set; }
            public override void Print()
            {
                Console.WriteLine("Course Information");
                Console.WriteLine("---------------------");
                base.Print();
                Console.WriteLine($"Duration: {Duration}");
                Console.WriteLine($"Description: {Description}");
                Console.WriteLine($"Topic Id: {topicId}");
                Console.WriteLine("----------------------");
            }
        }
    }
}
#endregion

#region Task 9
namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Topic topic = new Topic 
            { 
                Id = 1, 
                Name = "Osama Sobhy", 
                EntityName = nameof(Topic) 
            };
            topic.Print();

            Course course = new Course
            {
                Id = 1,
                Name = "Full Stack .NET",
                Duration = 12,
                Description = "Some Description",
                topicId = topic.Id,
                EntityName = nameof(Course)
            };
            course.Print();
        }
        class BaseEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
            internal string EntityName { get; set; }

            public virtual void Print()
            {
                Console.WriteLine($"Entity Name: {EntityName}");
                Console.WriteLine($"Id: {Id}");
                Console.WriteLine($"Name: {Name}");
            }
        }
        class Topic : BaseEntity
        {
            public override void Print()
            {
                Console.WriteLine("Topic Information");
                Console.WriteLine("------------------");
                base.Print();
                Console.WriteLine("------------------");
            }
        }

        class Course : BaseEntity
        {
            public int Duration { get; set; }
            public string Description { get; set; }
            public int topicId { get; set; }
            public override void Print()
            {
                Console.WriteLine("Course Information");
                Console.WriteLine("---------------------");
                base.Print();
                Console.WriteLine($"Duration: {Duration}");
                Console.WriteLine($"Description: {Description}");
                Console.WriteLine($"Topic Id: {topicId}");
                Console.WriteLine("----------------------");
            }
        }
    }
}

#endregion

#region Task 10
namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course(1, "Full Stack .NET", 12, "Some Description", 1);
            Console.WriteLine($"Id: {course.Id}");
            Console.WriteLine($"Name: {course.Name}");
            Console.WriteLine($"Create Date: {course.CreateDate}");
            Console.WriteLine($"Duration: {course.Duration}");
            Console.WriteLine($"Description: {course.Description}");
            Console.WriteLine($"Topic Id: {course.TopicId}");
        }
        class BaseEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public BaseEntity(int id, string name)
            {
                Id = id;
                Name = name;
            }
        }

        class BaseEntityWithCreateDate : BaseEntity
        {
            public DateTime CreateDate { get; set; }

            public BaseEntityWithCreateDate(int id, string name): base(id, name) { 
                CreateDate = DateTime.Now;
            }
        }
        class Course : BaseEntityWithCreateDate
        {
            public int Duration { get; set; }
            public string Description { get; set; }
            public int TopicId { get; set; }

            public Course(int id, 
                string name, int duration, string description, int topicId)
                : base(id, name)
            {
                Duration = duration;
                Description = description;
                TopicId = topicId;
            }
        }
    }
}

#endregion

#region Task 11
namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HireDate hireDate = new HireDate(5, 9, 2026);
            Topic topic1 = new Topic(1, "C# Basics");
            Topic topic2 = new Topic { Id = 2, Name = "Datebase", EntityName = nameof(Topic) };

            Course course1 = new Course
                (1, "C# Fundamentals", 30, "Learn C# fundamentals", topic1.Id);

            Course course2 = new Course
                (2, "SQL & Entity Framework", 40, "Learn SQL and Entity Framework", topic2.Id);

            topic1.Print();
            Console.WriteLine();
            topic2.Print();
            Console.WriteLine();
            course1.Print();
            Console.WriteLine();
            course2.Print();
        }
        struct HireDate
        {
            public int Day;
            public int Month;
            public int Year;

            public HireDate(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }
        }

        class BaseEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
            internal string EntityName { get; set;}

            public BaseEntity() { }
            public BaseEntity(int id, string name)
            {
                Id = id;
                Name = name;
            }
            public virtual void Print()
            {
                Console.WriteLine($"Entity Name: {EntityName}");
                Console.WriteLine($"Id: {Id}");
                Console.WriteLine($"Name: {Name}");
            }
        }
        class Topic : BaseEntity
        {
            public Topic() { }
            public Topic(int id, string name) : base(id, name)
            {
                EntityName = nameof(Topic);
            }
            public override void Print()
            {
                Console.WriteLine("Topic Information");
                Console.WriteLine("-------------------");
                base.Print();
                Console.WriteLine("-------------------");
            }
        }
        class BaseEntityWithCreateDate : BaseEntity
        {
            public DateTime CreateDate { get; set; }

            public BaseEntityWithCreateDate(int id, string name) : base(id, name)
            {
                CreateDate = DateTime.Now;
            }
        }
        class Course: BaseEntityWithCreateDate
        {
            public int Duration { get; set; }
            public string Description { get; set; }
            public int TopicId { get; set; }

            public Course(int id, 
                string name, int duration, 
                string descirption, int topicId)
                : base(id, name)
            {
                Duration = duration;    
                Description = descirption;
                TopicId = topicId;
                EntityName = nameof(Course);
            }

            public override void Print()
            {
                Console.WriteLine("Course Information");
                Console.WriteLine("---------------------");
                base.Print();
                Console.WriteLine($"Duration: {Duration}");
                Console.WriteLine($"Description: {Description}");
                Console.WriteLine($"Topic Id: {TopicId}");
                Console.WriteLine("---------------------");
            }
        }
    }
}

#endregion

