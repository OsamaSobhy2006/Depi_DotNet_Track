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
