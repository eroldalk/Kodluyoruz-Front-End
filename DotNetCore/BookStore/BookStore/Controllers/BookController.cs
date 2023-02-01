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
    }
}
