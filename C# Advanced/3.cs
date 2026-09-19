namespace C# Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 3. GENERIC REPOSITORY
            Console.WriteLine();
            Console.WriteLine("=== 3. GENERIC REPOSITORY ===");

            GenericRepository<Item> repository = new GenericRepository<Item>();
            repository.Add(new Item(1, "Pallet A", 20));
            repository.Add(new Item(2, "Pallet B", 30));
            repository.Add(new Item(3, "Pallet C", 40));

            Item? fetchedItem = repository.GetById(1);
            if (fetchedItem != null)
                Console.WriteLine($"Fetched: {fetchedItem}");

            bool removed = repository.Remove(2);
            Console.WriteLine($"Removed Item #2: {removed}");

            List<Item> remainingItems = repository.GetAll();
            Console.WriteLine($"Remaining items count: " + $"{remainingItems.Count}");

        }
    }
    
    public class BaseEntity
    {
        public int Id { get; set; }
    }

    public class Item : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public Item(int id, string title, int quantity)
        {
            Id = id;
            Title = title;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"Item #{Id} - {Title} (Qty: {Quantity})";
        }
    }

    public interface IRepository<T> where T : BaseEntity
    {
        void Add(T item);
        T? GetById(int id);
        List<T> GetAll();
        bool Remove(int id);
    }

    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly List<T> _items = new List<T>();
        public void Add(T item)
        {
            _items.Add(item);
        }
        public T? GetById(int id)
        {
            foreach (T item in _items)
            {
                if (item.Id == id)
                    return item;
            }

            return null;
        }
        public List<T> GetAll()
        {
            return new List<T>(_items);
        }
        public bool Remove(int id)
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Id == id)
                {
                    _items.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }
    }
}