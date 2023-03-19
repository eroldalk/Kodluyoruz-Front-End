using System;
using System.Linq;
using BookStore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.DBOperations
{

    public class DataGenerator
    {
        public static void Initiallize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if(context.Books.Any())
                {
                    return;
                }

                context.Genres.AddRange
                (
                    new Genre
                    {
                        Name = "Personel Growth"
                    },
                    new Genre
                    {
                        Name = "Science Fiction"
                    },
                    new Genre
                    {
                        Name = "Romance"
                    }
                );

                context.Books.AddRange( 
                    new Book
                    {
                       // Id = 1,
                        Title = "Mia ve Siyah",
                        GenreId = 1,
                        PageCount = 200,
                        Publishdate = new DateTime(2001,06,12)
                    },
                    new Book
                    {
                      //  Id = 2,
                        Title = "Paradoks",
                        GenreId = 2,
                        PageCount = 250,
                        Publishdate = new DateTime(2010,07,18)
                    },
                    new Book
                    {
                      //  Id = 3,
                        Title = "Kavgam",
                        GenreId = 2,
                        PageCount = 540,
                        Publishdate = new DateTime(2001,12,21)
                    });


                    context.SaveChanges();

            }
        }
       

    }
}
