using Books.Models;
using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using Google.Apis.Services;


namespace API.Repository
{
    public class BooksRepository : IBookRepository
    {
        private List<Book> books = new List<Book>();

        // C    
        public int AddBook(Book newBook) { newBook.Id = books.Count + 1; books.Add(newBook); return newBook.Id; }
        // R    
        public List<Book> GetBooks() => books;
        // U    

        // D    
        public int DeleteBook(Book delBook) { books.Remove(delBook); return delBook.Id; }
    }
}
