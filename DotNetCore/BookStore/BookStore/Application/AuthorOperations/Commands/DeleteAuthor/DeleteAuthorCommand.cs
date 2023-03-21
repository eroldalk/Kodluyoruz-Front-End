using System;
using System.Linq;
using BookStore.DBOperations;
using BookStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Application.AuthorOperations.DeleteAuthor
{
    public class DeleteAuthorCommand
    {
        public int AuthorId { get; set; }
        private readonly IBookStoreDbContext  _context;


        public DeleteAuthorCommand(IBookStoreDbContext  context)
        {
            _context = context;

        }

        public void Handle()
        {
           var author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);
            
            if(author is null)
                throw new InvalidOperationException("author not found.");

            _context.Authors.Remove(author);
            _context.SaveChanges();
        }

    }


}