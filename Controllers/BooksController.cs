using API.Data.Services;
using API.Repository;
using Books.Models;
using Google.Apis.Books.v1;
using Google.Apis.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //INITIALIZE THE REPO & SERVICE
        private readonly BooksRepository bookRepo;
        //public BookService _bookService;

        public BooksController(BookService bookService)
        {
            bookRepo = new BooksRepository();
            //_bookService = bookService;
        }

        // GET: api/<BooksController>
        [HttpGet]
        public IActionResult GetBooks()
        {
//  DOTNET EXAMPLE
        // Create the service.
        // var service = new BooksService(new BaseClientService.Initializer
        //{
        //    ApplicationName = "Books Sample",
        //    ApiKey = "AIzaSyCGNuFFRglnl68jSpKHAb-33SD5CrYiTRE",
        //});

        //      RUN THE REQUEST
        // Console.WriteLine("Executing a list request...");
        //    var result = await service.Apis.List().ExecuteAsync();

        //    // Display the results.
        //    if  (result.Items != null)
        //    {
        //        foreach (DirectoryList.ItemsData api in result.Items)
        //        {
        //            Console.WriteLine(api.Id + " - " + api.Title);
        //        }
        //    }

            // string testUrl = String.Format("https://www.googleapis.com/books/v1/volumes?q=quilting");
            string testUrl = String.Format("https://jsonplaceholder.typicode.com/posts");
            WebRequest requestObj = WebRequest.Create(testUrl);
            requestObj.Method = "GET";
            try { 
            HttpWebResponse responseObj = (HttpWebResponse)requestObj.GetResponse();

            string streamResult = null;
            using (Stream str = responseObj.GetResponseStream())
            {
                StreamReader _reader = new StreamReader(str);
                streamResult = _reader.ReadToEnd();
                _reader.Close();
            }
            return Ok(streamResult);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public Book GetBook(int id)
        {
            try
            {
                List<Book> AllBooks = bookRepo.GetBooks();
                Book? book = AllBooks.Where(book => book.Id == id).FirstOrDefault();
                if (book != null)
                {
                    return book;
                }
                return new Book();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new Book();
            }
        }

        // POST api/<BooksController>
        [HttpPost("")]
        public IActionResult AddNewBook([FromBody] Book NewBook)
        {
            try
            {
                bookRepo.AddBook(NewBook);
                return Ok(NewBook.Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                ////return Error(e);
                //var error = new ErrorViewModel
                //{
                //    Message = e.Message,
                //    Details = e.StackTrace,
                //    ErrorCode = "UNEXPECTED_ERROR"
                //};
                return BadRequest(e);
            }
        }

        //// PUT api/<BooksController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Book? delBook = bookRepo.GetBooks().Where(b => b.Id == id).FirstOrDefault();
            if (delBook != null) { bookRepo.DeleteBook(delBook); }

        }
    }
}
