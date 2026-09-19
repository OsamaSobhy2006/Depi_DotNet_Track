namespace C# Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
             // 2. GENERIC PRODUCTS
            Console.WriteLine();
            Console.WriteLine("=== 2. GENERIC PRODUCTS ===");
            Product<int, string> product1 = new Product<int, string>(101, "Laptop", "Electronics", 1200m);
            Product<string, string> product2 = new Product<string, string>("SKU-990","Desk Chair","Furniture",150m);
            Console.WriteLine(product1);
            Console.WriteLine(product2);
        }
    }
    
    public class Product<TId, TCategory>
    {
        public TId Id { get; set; }
        public string Name { get; set; }
        public TCategory Category { get; set; }
        public decimal Price { get; set; }

        public Product(TId id, string name, TCategory category, decimal price)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
        }

        public override string ToString()
        {
            return $"[Product ID: {Id}] {Name} | " + $"Category: {Category} | " + $"Price: ${Price:N2}";
        }
    }
}