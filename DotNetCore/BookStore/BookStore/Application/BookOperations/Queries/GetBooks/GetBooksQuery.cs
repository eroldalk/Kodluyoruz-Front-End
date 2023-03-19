using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BookStore.DBOperations;
using BookStore.Common;
using AutoMapper;
using BookStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.BookOperations.GetBooks
{
    public class GetBooksQuery 
    {
        private readonly BookStoreDbContext _dbcontext;

        private readonly IMapper _mapper;

        public GetBooksQuery(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbcontext = dbContext;
            _mapper = mapper;
        }

        public List<BooksViewModel> Handle()
        {
            var bookList = _dbcontext.Books.Include(x => x.Genre).OrderBy(x => x.Id).ToList<Book>();
            List<BooksViewModel> vm = _mapper.Map<List<BooksViewModel>>(bookList);                     //new List<BooksViewModel>();


            //foreach (var book in BookList)
            //{
            //    vm.Add(new BooksViewModel()
            //    {
            //        Title = book.Title,
            //        GenreId = ((GenreEnum)book.GenreId).ToString(),
            //        Publishdate = book.Publishdate.Date.ToString("dd/MM/yyyy"),
            //        PageCount = book.PageCount
            //    });
            //}
            return vm;

        }
    }
    public class BooksViewModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string Publishdate { get; set; }
        public string Genre { get; set; }

    }
}