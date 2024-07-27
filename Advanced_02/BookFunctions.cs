using System.Text;

namespace Advanced_02
{
    public class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            try
            {
                return book?.Title ?? "The book has no title";
            }
            catch (Exception ex)
            {
                return $"Internal error occured: {ex.Message}";
            }
        }

        public static string GetAuthors(Book book)
        {
            try
            {
                if (book is null)
                    return "Book was not found";
                if(book.Authors is null)
                    return "No authors found";
                //StringBuilder authors = new("");
                //foreach (var author in book.Authors)
                //{
                //    authors.Append($"{author}, ");
                //}
                //return authors.ToString(0, authors.Length - 2);
                //Another solution
                string authors02 = string.Join(", ", book?.Authors);
                return authors02;
            }
            catch (Exception ex)
            {
                return $"Internal error occured: {ex.Message}";
            }
        }

        public static string GetPrice(Book book)
        {
            try
            {
                decimal price = book?.Price ?? 0;
                return price == 0 ? "The book has no price" : $"The book {book.Title} costs ${price}";
            }
            catch (Exception ex)
            {
                return $"Internal error occured: {ex.Message}";
            }
        }
    }
}
