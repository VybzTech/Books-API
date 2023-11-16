using Books.Models;
using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using Google.Apis.Services;


namespace API.Repository
{
    public class BooksRepository : IBookRepository
    {
        //   Create the service
 //       var service = BooksService(new BaseClientService().HttpClientInitializer{
 //           ApplicationName: "Books",
 //           ApiKey = "[AIzaSyCGNuFFRglnl68jSpKHAb-33SD5CrYiTRE]",
 //           });    
 //   //      RUN THE REQUEST
 //                   Console.WriteLine("api.Id + " - " + api.Title....");
 //       var result = await ServiceCollection.Apis.List().ExecuteAsync();
 //mbox 
        //    // Display the results.
        //    if (result.Items != null)
        //    {
        //        foreach (DirectoryList.ItemsData api in result.Items)
        //        {
        //            Console.WriteLine(api.Id + " - " + api.Title);
        //        }
        //    }
        //}
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
