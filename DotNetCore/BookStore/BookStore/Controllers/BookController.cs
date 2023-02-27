using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[Controller]s")]

    public class BookController : ControllerBase
    {
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

        // daha doğru
        [HttpGet]
        public List<Book> GetBooks()   
        {
            var bookList = BookList.OrderBy(x => x.Id).ToList<Book>();
            return BookList;
        }

        [HttpGet("{id}")]
        public Book GetById(int id)
        {
        var book = BookList.Where(book => book.Id == id).SingleOrDefault();
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
            var book = BookList.SingleOrDefault(x=> x.Title == newBook.Title);
             
            if(book is not null)
                return BadRequest();

            BookList.Add(newBook);
            return Ok();

        }

        //put
        [HttpPut("(id)")]

        public IActionResult UpdateBook(int id, [FromBody] Book UpdateBook)
        {
            var book = BookList.SingleOrDefault(x=> x.Id == id);
             
            if(book is null)
                return BadRequest();

            book.GenreId= UpdateBook.GenreId !=default ? UpdateBook.GenreId : book.GenreId;
            book.PageCount= UpdateBook.PageCount !=default ? UpdateBook.PageCount : book.PageCount;
            book.Publishdate= UpdateBook.Publishdate !=default ? UpdateBook.Publishdate : book.Publishdate;
            book.Title= UpdateBook.Title !=default ? UpdateBook.Title : book.Title;

            return Ok();

        }

       
        [HttpDelete("id")]

         public IActionResult DeleteBook(int id)   //, [FromBody] Book DeleteBook
        {
            var book = BookList.SingleOrDefault(x=> x.Id == id);
             
            if(book is null)
                return BadRequest();

            BookList.Remove(book);
            return Ok();

        }






    }
}
