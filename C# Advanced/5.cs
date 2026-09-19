namespace C# Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 5. QUEUE - ORDER PROCESSING
            Console.WriteLine();
            Console.WriteLine("=== 5. QUEUE (ORDER PROCESSING) ===");

            OrderQueue orderQueue = new OrderQueue();

            orderQueue.EnqueueOrder(new Order(1, "Ahmed", 300));
            orderQueue.EnqueueOrder(new Order(2, "Sara", 150));
            orderQueue.EnqueueOrder(new Order(3, "Omar", 500));
            orderQueue.EnqueueOrder(new Order(4, "Mona", 250));
            Order? order1 = orderQueue.ProcessNextOrder();
            if (order1 != null)
                Console.WriteLine($"Processing: {order1}");

            Order? order2 = orderQueue.ProcessNextOrder();
            if (order2 != null)
                Console.WriteLine($"Processing: {order2}");

            Console.WriteLine($"Orders still pending: " + $"{orderQueue.PendingCount}");

        }
    }
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public Order(int id, string customer, decimal amount)
        {
            OrderId = id;
            CustomerName = customer;
            TotalAmount = amount;
        }
        public override string ToString()
        {
            return $"Order #{OrderId} for {CustomerName} (${TotalAmount})";
        }
    }
    
    public class OrderQueue
    {
        private Queue<Order> _orders = new Queue<Order>();
        public void EnqueueOrder(Order order)
        {
            _orders.Enqueue(order);
        }
        public Order? ProcessNextOrder()
        {
            if (_orders.Count == 0)
                return null;

            return _orders.Dequeue();
        }

        public Order? PeekNextOrder()
        {
            if (_orders.Count == 0)
                return null;

            return _orders.Peek();
        }
        public int PendingCount => _orders.Count;
    }
}