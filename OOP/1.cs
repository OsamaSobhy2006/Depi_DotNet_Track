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
