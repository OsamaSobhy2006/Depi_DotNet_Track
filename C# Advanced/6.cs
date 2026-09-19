namespace C# Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 6. DICTIONARY - INVENTORY STOCK
            Console.WriteLine();
            Console.WriteLine("=== 6. DICTIONARY (INVENTORY STOCK) ===");
            InventoryStock inventory = new InventoryStock();
            inventory.SetStock("ELEC-01", 50);
            inventory.SetStock("FURN-02", 15);
            inventory.SetStock("FOOD-03", 120);
            // Update existing stock
            inventory.SetStock("ELEC-01", 45);
            inventory.PrintInventory();
            Console.WriteLine($"Stock for FURN-02: " + $"{inventory.GetStock("FURN-02")}");
            Console.WriteLine($"Stock for UNKNOWN: " + $"{inventory.GetStock("UNKNOWN")}");

        }
    }
    public class InventoryStock
    {
        private Dictionary<string, int> _stock = new Dictionary<string, int>();

        public void SetStock(string sku, int quantity)
        {
            if (_stock.ContainsKey(sku))
                _stock[sku] = quantity;
            else
                _stock.Add(sku, quantity);
        }

        public int GetStock(string sku)
        {
            if (_stock.TryGetValue(sku, out int quantity))
                return quantity;

            return 0;
        }

        public void PrintInventory()
        {
            foreach (KeyValuePair<string, int> item in _stock)
            {
                Console.WriteLine($"SKU {item.Key} -> Quantity: {item.Value}");
            }
        }
    }
}