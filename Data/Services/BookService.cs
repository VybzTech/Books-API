using Books.Models;

namespace API.Data.Services
{
    public class BookService
    {
        //  Inject App DBContext File
        private BooksContext _context;
        public BookService(BooksContext context)
        {

            _context = context;

        }
        //  CREATE FIRST METTHOD
        public void AddBook(Book book)
        {
            var _book = new Book() { Title = book.Title, Des = book.Des };
            //newBook.Id = books.Count + 1; books.Add(newBook); return newBook.Id; }
            _context.BookStore.Add(_book);
            _context.SaveChanges();
        }
    }
}
