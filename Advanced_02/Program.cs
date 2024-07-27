namespace Advanced_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new(null, null, null, DateTime.UtcNow, 50.23m);
            Book book2 = new("20235040", "Book2", new[]{ "Ahmed", "Helal"}, DateTime.UtcNow, 150.23m);
            Console.WriteLine(book1.ToString());
            Console.WriteLine("<===============================>");
            Console.WriteLine(book2.ToString());
            Console.WriteLine("<===============================>");
            Console.WriteLine(BookFunctions.GetAuthors(book1));
            Console.WriteLine(BookFunctions.GetTitle(book1));
            Console.WriteLine(BookFunctions.GetPrice(book1));
            Console.WriteLine("<===============================>");
            Console.WriteLine(BookFunctions.GetAuthors(book2));
            Console.WriteLine(BookFunctions.GetTitle(book2));
            Console.WriteLine(BookFunctions.GetPrice(book2));
        }
    }
}