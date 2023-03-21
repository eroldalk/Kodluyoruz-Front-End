using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BookStore.DBOperations;

namespace BookStore.Application.AuthorOperations.Queries.GetAuthorDetail
{
    public class GetAuthorDetailQuery
   {
        public int AuthorId { get; set; }
        public readonly IBookStoreDbContext  _context;
        public readonly IMapper _mapper;

        public GetAuthorDetailQuery( IBookStoreDbContext  context ,IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }



        public AuthorDetailViewModel Handle()
        {
            var Author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);
            if(Author is null)
                throw new InvalidOperationException("The Author not found");
            return _mapper.Map<AuthorDetailViewModel>(Author);
        } 

    }

    public class AuthorDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
    } 


}







