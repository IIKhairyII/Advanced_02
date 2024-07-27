namespace Advanced_02
{
    public class Book
    {
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public Book(string isbn,
            string title,
            string[] authors,
            DateTime publicationDate,
            decimal price)
        {
            ISBN = isbn;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }

        public override string ToString()
        {
            return $"The book with title {Title ?? ""} has an isbn: {ISBN ?? ""}. This book was publicated in {PublicationDate.ToString("dd/MM/yyyy")}.\n" +
                $"This book costs ${Price}";
        }
    }
}
