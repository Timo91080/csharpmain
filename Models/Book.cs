namespace BiblioWorld.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }   // Remplacé AuthorID
        public string GenreName { get; set; }    // Remplacé GenreID
        public int PublishedYear { get; set; }
        public string Summary { get; set; }
        public string image_book_url { get; set; }
        public string PurchaseLink { get; set; }
    }
}
