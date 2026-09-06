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
