using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BookStore.DBOperations;
using BookStore.BookOperations.GetBooks;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[Controller]s")]

    public class BookController : ControllerBase
    {

        private readonly BookStoreDbContext _context;

        public BookController (BookStoreDbContext context)
        {
            _context = context;
        }

      /* 
        private static List<Book> BookList = new List<Book>()
        {
            new Book
            {
                Id = 1,
                Title = "Mia ve Siyah",
                GenreId = 1,
                PageCount = 200,
                Publishdate = new DateTime(2001,06,12)
            },
             new Book
            {
                Id = 2,
                Title = "Paradoks",
                GenreId = 2,
                PageCount = 250,
                Publishdate = new DateTime(2010,07,18)
            },
             new Book
            {
                Id = 3,
                Title = "Kavgam",
                GenreId = 2,
                PageCount = 540,
                Publishdate = new DateTime(2001,12,21)
            }
        };
    */
        // daha doğru
        [HttpGet]
        public IActionResult GetBooks()   
        {
            GetBooksQuery query = new GetBooksQuery(_context);
            var result = query.Handle();
            return Ok(result);

           // var bookList = _context.Books.OrderBy(x => x.Id).ToList<Book>();
           // return bookList;
        }

        [HttpGet("{id}")]
        public Book GetById(int id)
        {
        var book = _context.Books.Where(book => book.Id == id).SingleOrDefault();
            return book;
        }

        //[HttpGet]
       // public Book Get([FromQuery] string id)
       // {
       //     var book = BookList.Where(book => book.Id == Convert.ToInt32(id)).SingleOrDefault();
       //     return book;
       // }

        //post
        [HttpPost]
        public IActionResult AddBook ([FromBody] Book newBook)
        {
            var book = _context.Books.SingleOrDefault(x=> x.Title == newBook.Title);
             
            if(book is not null)
                return BadRequest();

            _context.Books.Add(newBook);
            _context.SaveChanges();
            return Ok();

        }

        //put
        [HttpPut("(id)")]

        public IActionResult UpdateBook(int id, [FromBody] Book UpdateBook)
        {
            var book = _context.Books.SingleOrDefault(x=> x.Id == id);
             
            if(book is null)
                return BadRequest();

            book.GenreId= UpdateBook.GenreId !=default ? UpdateBook.GenreId : book.GenreId;
            book.PageCount= UpdateBook.PageCount !=default ? UpdateBook.PageCount : book.PageCount;
            book.Publishdate= UpdateBook.Publishdate !=default ? UpdateBook.Publishdate : book.Publishdate;
            book.Title= UpdateBook.Title !=default ? UpdateBook.Title : book.Title;

            _context.SaveChanges();
            return Ok();

        }

       
        [HttpDelete("id")]

         public IActionResult DeleteBook(int id)   //, [FromBody] Book DeleteBook
        {
            var book = _context.Books.SingleOrDefault(x=> x.Id == id);
             
            if(book is null)
                return BadRequest();

            _context.Books.Remove(book);
            _context.SaveChanges();
            return Ok();

        }






    }
}
