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
