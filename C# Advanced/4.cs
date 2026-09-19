namespace C# Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 4. STACK - UNDO HISTORY
            Console.WriteLine();
            Console.WriteLine("=== 4. STACK (UNDO HISTORY) ===");
            ActionTracker tracker = new ActionTracker();
            tracker.RecordAction("Added Item 101");
            tracker.RecordAction("Updated Stock");
            tracker.RecordAction("Deleted Item 103");
            tracker.Undo();
            tracker.Undo();

        }
    }
    public class ActionTracker
    {
        private Stack<string> _history = new Stack<string>();

        public void RecordAction(string action)
        {
            _history.Push(action);
            Console.WriteLine($"Action recorded: {action}");
        }
        public void Undo()
        {
            if (_history.Count > 0)
            {
                string action = _history.Pop();
                Console.WriteLine($"Undone: {action}");
            }
            else
                Console.WriteLine("No actions to undo!");

        }

        public void PrintLatestAction()
        {
            if (_history.Count > 0)
                Console.WriteLine($"Latest action: {_history.Peek()}");
            else
                Console.WriteLine("No actions to undo!");
        }
    }
}