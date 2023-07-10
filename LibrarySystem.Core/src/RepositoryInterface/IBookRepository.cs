using LibrarySystem.Core.src.Entity;

namespace LibrarySystem.Core.src.RepositoryInterface
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        Book? GetBookById(int id);
        Book UpdateBook(Book book, string? title, double? price);
        bool DeleteBook(Book book);
        Book CreateNewBook(Book book);
    }
    
}