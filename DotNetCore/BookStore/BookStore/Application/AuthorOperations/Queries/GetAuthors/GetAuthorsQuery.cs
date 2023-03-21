using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BookStore.DBOperations;
using BookStore.Entities;

namespace BookStore.Application.AuthorOperations.Queries.GetAuthors
{
    public class GetAuthorsQuery
   {
        public readonly BookStoreDbContext _context;
        public readonly IMapper _mapper;

        public GetAuthorsQuery( BookStoreDbContext context ,IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }



        public List<AuthorsViewModel> Handle()
        {
            var authors = _context.Authors.OrderBy(a => a.Id).ToList<Author>();
            List<AuthorsViewModel> returnObj = _mapper.Map<List<AuthorsViewModel>>(authors);
            return returnObj;
        } 

    }

    public class AuthorsViewModel
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public String Birthday { get; set; }
        public List<Book> Books { get; set; }
    }


}







