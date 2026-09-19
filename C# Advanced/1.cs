namespace C# Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. EXTENSION METHODS
            Console.WriteLine("=== 1. EXTENSION METHODS ===");
            int quantity = 45;
            Console.WriteLine($"Quantity {quantity} between 1 and 100: " + $"{quantity.IsBetween(1, 100)}");
            string text = "Warehouse System";
            Console.WriteLine($"Vowels in '{text}': {text.CountVowels()}");
            Console.WriteLine($"Reversed text: {text.ReverseText()}");

        }
    }
    public static class CustomExtensions
    {
        public static bool IsBetween(this int value, int min, int max)
        {
            return value >= min && value <= max;
        }

        public static int CountVowels(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0;

            int count = 0;
            foreach (char c in text)
            {
                char lower = char.ToLower(c);
                if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
                    count++;
            }
            return count;
        }

        public static string ReverseText(this string text)
        {
            if (text == null)
                return string.Empty;

            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}