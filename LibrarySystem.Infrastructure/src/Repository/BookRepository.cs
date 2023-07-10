using LibrarySystem.Core.src.Entity;
using LibrarySystem.Core.src.RepositoryInterface;

namespace LibrarySystem.Infrastructure.src.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly List<Book> _books;

        public BookRepository()
        {
            _books  = new();
        }
        public Book CreateNewBook(Book book)
        {
            _books.Add(book);
            return book;
        }

        public bool DeleteBook(Book book)
        {
            return _books.Remove(book);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }

        public Book? GetBookById(int id)
        {
            return _books.Find(b => b.Id == id);
        }
        public Book UpdateBook(Book book, string? title, double? price)
        {
            book.UpdateBook(title, price);
            return book;
        }
    }
}