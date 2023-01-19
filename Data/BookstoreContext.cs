using System;
using Bookstore.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Data
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options)
        : base(options)
        { }

        public DbSet<Book> Books { get; set; }
    }
}

