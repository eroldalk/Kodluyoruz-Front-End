using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BookStore.DBOperations;
using BookStore.Common;

namespace BookStore.BookOperations.GetBooks
{
    public class GetBooksQuery 
    {
        private readonly BookStoreDbContext _dbcontext;
        
        
        public GetBooksQuery (BookStoreDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public List<BooksViewModel> Handle()
        {
            var BookList = _dbcontext.Books.OrderBy(x => x.Id).ToList<Book>();
            List<BooksViewModel> vm = new List<BooksViewModel>();
            foreach (var book in BookList)
            {
                vm.Add(new BooksViewModel()
                {
                    Title = book.Title,
                    GenreId = ((GenreEnum)book.GenreId).ToString(),
                    Publishdate = book.Publishdate.Date.ToString("dd/MM/yyyy"),
                    PageCount = book.PageCount
                });
            }
            return vm;

        }
    }
    public class BooksViewModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string Publishdate { get; set; }
        public string GenreId { get; set; }

    }
}