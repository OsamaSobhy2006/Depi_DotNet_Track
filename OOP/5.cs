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
