using System;
using Bookstore.Data;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookstoreContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BookstoreContext>>()))
            {
                // Look for any movies.
                if (context.Books.Any())
                {
                    return;   // DB has been seeded
                }

                context.Books.AddRange(
                    new Book
                    {
                        Title = "Władca Pierścieni",
                        Author = "J.R.R. Tolkien",
                        Price = 29.99m,
                        Description = "Fantastyczna opowieść o wojnie o pierścień"
                    },

                    new Book
                    {
                        Title = "Hobbit",
                        Author = "J.R.R. Tolkien",
                        Price = 24.99m,
                        Description = "Fantastyczna przygoda hobbita"
                    },

                    new Book
                    {
                        Title = "Władca Pierścieni",
                        Author = "J.K. Rowling",
                        Price = 19.99m,
                        Description = "Magia w szkole czarodziejów"
                    }


                );
                context.SaveChanges();
            }
        }
    }
}

