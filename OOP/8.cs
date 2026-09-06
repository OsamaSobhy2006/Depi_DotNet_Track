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