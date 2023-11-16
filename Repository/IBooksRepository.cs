using Books.Models;

namespace API.Repository
{
    public interface IBookRepository
    {
        // C    
        public int AddBook(Book newBook);
        // R    
        public List<Book> GetBooks();
        // U    

        // D    
        public int DeleteBook(Book delBook);

    }
}