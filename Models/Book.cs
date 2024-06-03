namespace BookStoreApi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public decimal Price { get; set; }
        public required string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public required Category Category { get; set; }
        public required List<BookAuthor> BookAuthors { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required List<Book> Books { get; set; }
    }

    public class Author
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required List<BookAuthor> BookAuthors { get; set; }
    }

    public class BookAuthor
    {
        public int BookId { get; set; }
        public required Book Book { get; set; }
        public int AuthorId { get; set; }
        public required Author Author { get; set; }
    }
}
