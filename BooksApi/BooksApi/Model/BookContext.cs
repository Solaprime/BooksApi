using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApi.Model
{
    public class BookContext : DbContext
    {

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //}
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }
        public DbSet<Book> Books { get; set; }
    }
}
