public static void Print<T>(IEnumerable<T> collection)
{
    foreach (var item in collection)
        Console.WriteLine(item);
}