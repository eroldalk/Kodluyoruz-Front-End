using System;
using System.Linq;
using BookStore.DBOperations;



namespace BookStore.BookOperations.DeleteBook
{
    public class DeleteBookCommand
    {


        private readonly BookStoreDbContext _dbcontext;
        public int BookId { get; set; }

        public DeleteBookCommand(BookStoreDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void Handle()
        {
            var book = _dbcontext.Books.SingleOrDefault(x => x.Id == BookId);

            if (book is null)
                throw new InvalidOperationException("Silinecek Kitap Bulunamadı!");

            _dbcontext.Books.Remove(book);
            _dbcontext.SaveChanges();
        }
    }
}
