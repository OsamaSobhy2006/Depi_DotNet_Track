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
