using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BookStore.DBOperations;
using BookStore.Common;
using AutoMapper;
//using Microsoft.EntityFrameworkCore;

namespace BookStore.BookOperations.GetBookDetail
{
    public class GetBookDetailQuery
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public int BookId { get; set; }
        public GetBookDetailQuery(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;   
        }

        public BookDetailViewModel Handle()
        {
            var book = _dbContext.Books.Where(book => book.Id == BookId).SingleOrDefault();
            if (book is null)
            throw new InvalidOperationException("Kitap Bulunamadı !");

            BookDetailViewModel vm = _mapper.Map<BookDetailViewModel>(book);    //new BookDetailViewModel();

            //vm.Title = book.Title;
            //vm.PageCount = book.PageCount;
            //vm.Publishdate = book.Publishdate.Date.ToString("dd/MM/yyyy");
            //vm.Genre = ((GenreEnum)book.GenreId).ToString();

            return vm;
        }
    }


    public class BookDetailViewModel
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int PageCount { get; set; }
        public string Publishdate { get; set; }

    }

}
