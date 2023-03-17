using System;
using Microsoft.AspNetCore.Mvc;
using BookStore.DBOperations;
using BookStore.BookOperations.GetBooks;
using BookStore.BookOperations.CreateBook;
using BookStore.BookOperations.GetBookDetail;
using BookStore.BookOperations.UpdateBook;
using BookStore.BookOperations.DeleteBook;
using static BookStore.BookOperations.UpdateBook.UpdateBookCommand;
using static BookStore.BookOperations.CreateBook.CreateBookCommand;
using AutoMapper;
using FluentValidation.Results;
using FluentValidation;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[Controller]s")]

    public class BookController : ControllerBase
    {

        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;

        public BookController (BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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
            GetBooksQuery query = new GetBooksQuery(_context, _mapper);
            var result = query.Handle();
            return Ok(result);

           // var bookList = _context.Books.OrderBy(x => x.Id).ToList<Book>();
           // return bookList;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            BookDetailViewModel result;
            //try
            //{
                GetBookDetailQuery query = new GetBookDetailQuery(_context, _mapper);
                query.BookId = id;
                GetBookDetailQueryValidator validator = new GetBookDetailQueryValidator();
                validator.ValidateAndThrow(query);
                result = query.Handle();
                
            //}
            //catch (Exception ex)
            //{

            //    return BadRequest(ex.Message);
            //}
            return Ok(result);
                //var book = _context.Books.Where(book => book.Id == id).SingleOrDefault();
                //    return book;

        }

        //[HttpGet]
       // public Book Get([FromQuery] string id)
       // {
       //     var book = BookList.Where(book => book.Id == Convert.ToInt32(id)).SingleOrDefault();
       //     return book;
       // }

        //post
        [HttpPost]
        public IActionResult AddBook ([FromBody] CreateBookModel newBook)
        {
            CreateBookCommand command = new CreateBookCommand(_context, _mapper);
            //try
            //{
              command.Model = newBook;
              CreateBookCommandValidator validator = new CreateBookCommandValidator();
              validator.ValidateAndThrow(command);
              command.Handle();

                //if (!result.IsValid)
                //    foreach (var item in result.Errors)
                //        Console.WriteLine("Özellik " + item.PropertyName + "- Error Message: " + item.ErrorMessage);
                //else
                //      command.Handle();

            //}
            //catch (Exception ex)
            //{

            //    return BadRequest(ex.Message);
            //}
            return Ok();

            //var book = _context.Books.SingleOrDefault(x=> x.Title == newBook.Title);
             
            //if(book is not null)
            //    return BadRequest();

            //_context.Books.Add(newBook);
            //_context.SaveChanges();
            

        }

        //put
        [HttpPut("(id)")]

        public IActionResult UpdateBook(int id, [FromBody] UpdateBookModel UpdateBook)
        {
            //try
            //{
                UpdateBookCommand command = new UpdateBookCommand(_context);
                command.BookId = id;
                command.Model = UpdateBook;
                UpdateBookCommandValidator validator = new UpdateBookCommandValidator();
                validator.ValidateAndThrow(command);
                command.Handle();
            //}
            //catch (Exception ex)
            //{

            //    return BadRequest(ex.Message);
            //}
            return Ok();

            //var book = _context.Books.SingleOrDefault(x=> x.Id == id);

            //if(book is null)
            //    return BadRequest();

            //book.GenreId= UpdateBook.GenreId !=default ? UpdateBook.GenreId : book.GenreId;
            //book.PageCount= UpdateBook.PageCount !=default ? UpdateBook.PageCount : book.PageCount;
            //book.Publishdate= UpdateBook.Publishdate !=default ? UpdateBook.Publishdate : book.Publishdate;
            //book.Title= UpdateBook.Title !=default ? UpdateBook.Title : book.Title;
        }

       
        [HttpDelete("id")]

         public IActionResult DeleteBook(int id)   //, [FromBody] Book DeleteBook
        {

            //try
            //{
                DeleteBookCommand command = new DeleteBookCommand(_context);
                command.BookId = id;
                DeleteBookCommandValidator validator = new DeleteBookCommandValidator();
                validator.ValidateAndThrow(command);
                command.Handle();
            //}
            //catch (Exception ex)
            //{

            //    return BadRequest(ex.Message);
            //}
            return Ok();

            //var book = _context.Books.SingleOrDefault(x=> x.Id == id);

            //if(book is null)
            //    return BadRequest();

            //_context.Books.Remove(book);
            //_context.SaveChanges();


        }






    }
}
