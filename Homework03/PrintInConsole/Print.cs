

namespace PrintInConsole
{
    public class PrintConsole
    {
        public void Print<T>(T item)
        {
            Console.WriteLine($"Printing single object: {item}");
        }
        public void PrintCollection<T>(IEnumerable<T> collection)
        {
            Console.WriteLine("Printing collection:");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

        }
    }
}
