
using LibrarySystem.Core.src.Entity;
using LibrarySystem.Core.src.RepositoryInterface;
using LibrarySystem.Service.src.ServiceInterface;

namespace LibrarySystem.Service.src.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public Book CreateNewBook(string title, double price)
        {
            var book = new Book(title, price);
           return _bookRepository.CreateNewBook(book);
        }

        public bool DeleteBookById(int id)
        {
            var foundBook = _bookRepository.GetBookById(id);
            if (foundBook != null)
            {
                return _bookRepository.DeleteBook(foundBook);
            }
            throw new Exception("id not found"); 
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public Book GetBookById(int id)
        {
            var foundBook = _bookRepository.GetBookById(id);
            if(foundBook != null) return foundBook;
            throw new Exception("id not found");
        }

        public Book UpdateBookById(int id, string? title, double? price)
        {
            var foundBook = _bookRepository.GetBookById(id);
            if (foundBook != null)
            {
                return _bookRepository.UpdateBook(foundBook, title, price);
            }
            else
            {
                throw new Exception("id not found");
            }
        }
    }
}