using System;
using Microsoft.AspNetCore.Mvc;
using BookStore.DBOperations;
using static BookStore.BookOperations.UpdateBook.UpdateBookCommand;
using static BookStore.BookOperations.CreateBook.CreateBookCommand;
using AutoMapper;
using FluentValidation.Results;
using FluentValidation;
using BookStore.Application.GenreOperations.Queries.GetGenres;
using BookStore.Application.GenreOperations.Queries.GetGenreDetail;
using BookStore.Application.GenreOperations.CreateGenre;
using BookStore.Application.GenreOperations.UpdateGenre;
using BookStore.Application.GenreOperations.DeleteGenre;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[Controller]s")]

    public class GenreController : ControllerBase
    {
        public readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public GenreController(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetGenres()   
        {
            GetGenresQuery query = new GetGenresQuery(_context, _mapper);
            var obj = query.Handle();
            return Ok(obj);
        }



        [HttpGet("{id}")]
        public IActionResult GetGenreDetail(int id)
        {
            GetGenreDetailQuery query = new GetGenreDetailQuery(_context, _mapper);
            query.GenreId = id;
            GetGenreDetailQueryValidator validator = new GetGenreDetailQueryValidator();
            validator.ValidateAndThrow(query);
            var obj = query.Handle();          
            return Ok(obj);
        }


        [HttpPost]
        public IActionResult AddGenre([FromBody] CreateGenreModel newGenre)
        {
            CreateGenreCommand command = new CreateGenreCommand(_context);
            command.Model = newGenre;
            CreateGenreCommandValidator validator = new CreateGenreCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }


        [HttpPut("(id)")]
        public IActionResult UpdateGenre(int id, [FromBody] UpdateGenreModel UpdateGenre)
        {
            UpdateGenreCommand command = new UpdateGenreCommand(_context);
            command.GenreId = id;
            command.Model = UpdateGenre;
            UpdateGenreCommandValidator validator = new UpdateGenreCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }


        [HttpDelete("id")]
         public IActionResult DeleteGenre(int id)  
        {
            DeleteGenreCommand command = new DeleteGenreCommand(_context);
            command.GenreId = id;
            DeleteGenreCommandValidator validator = new DeleteGenreCommandValidator();
            
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }

    }
}