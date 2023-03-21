using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BookStore.DBOperations;


namespace BookStore.Application.AuthorOperations.UpdateAuthor
{
    public class UpdateAuthorCommand
    {

        
        public int AuthorId { get; set; }
        public UpdateAuthorModel Model { get; set; }
        private readonly IBookStoreDbContext  _context;
        public UpdateAuthorCommand(IBookStoreDbContext  context)
        {
            _context = context;
        }

        public void Handle()
        {
            var Author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);

            if (Author is null)
                throw new InvalidOperationException("No author found to be updated");

            //if (_context.Authors.Any(x => x.Name.ToLower() == Model.Name.ToLower() && x.Id != AuthorId))
              //   throw new InvalidOperationException("Aynı İsimli Yazar Zaten Mevcut.");

            //Author.Name = string.IsNullOrEmpty(Model.Name.Trim()) ? Author.Name : Model.Name;
            //Author.Surname = string.IsNullOrEmpty(Model.Surname.Trim()) ? Author.Surname : Model.Surname;
            //Author.Birthday = Model.Birthday != default ? Model.Birthday : Author.Birthday;


            Author.Name = Model.Name == default ? Author.Name : Model.Name;
            Author.Surname = Model.Surname == default ? Author.Surname : Model.Surname;
            //Author.Birthday=Convert.ToDateTime(Model.Birthday);

            _context.Authors.Update(Author);
            _context.SaveChanges();
        }
    
    }

    public class UpdateAuthorModel
    {
        public string Name { get; set; }
		public string Surname { get; set; }
		//public DateTime Birthday { get; set; }
    }


}

