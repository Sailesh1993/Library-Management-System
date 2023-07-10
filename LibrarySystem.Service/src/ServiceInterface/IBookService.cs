using LibrarySystem.Core.src.Entity;

namespace LibrarySystem.Service.src.ServiceInterface
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int id);
        Book UpdateBookById(int id,string? title, double? price);
        bool DeleteBookById(int id);
        Book CreateNewBook(string title, double price);
    }
}