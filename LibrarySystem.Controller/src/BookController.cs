using LibrarySystem.Core.src.Entity;
using LibrarySystem.Service.src.ServiceInterface;

namespace LibrarySystem.Controller.src
{
    public class BookController
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public Book CreateNewBook(string title, double price)
        {
            
           return _bookService.CreateNewBook(title, price);
        }

        public bool DeleteBookById(int id)
        {
            return _bookService.DeleteBookById(id);
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return _bookService.GetAllBooks();
        }

        public Book GetBookById(int id)
        {
            return _bookService.GetBookById(id);
        }

        public Book UpdateBookById(int id, string? title, double? price)
        {
            return _bookService.UpdateBookById(id, title, price);    
        }
    }
}