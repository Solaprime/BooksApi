using BooksApi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApi.Data
{
    public class BookData : IBookData
    {
        private readonly BookContext _bookContext;
        public BookData(BookContext bookContext)
        {
            _bookContext = bookContext;
        }
        public  async Task<Book> CreateBook(Book book)
        {
            _bookContext.Books.Add(book);
            await _bookContext.SaveChangesAsync();
            return book;
        }

        public  async Task DeleteBook(int Id)
        {
            var toDelete =  await _bookContext.Books.FindAsync(Id);
            _bookContext.Books.Remove(toDelete);
            await _bookContext.SaveChangesAsync();
          


        }

        public  async Task<IEnumerable<Book>> GetBook()
        {
            return await _bookContext.Books.ToListAsync();
        }

        public async Task<Book> GetBookById(int Id)
        {
            return await _bookContext.Books.FindAsync(Id);
        }

        public async  Task UpdateBook(Book book)
        {
            _bookContext.Entry(book).State = EntityState.Modified;
            await _bookContext.SaveChangesAsync();
        }

    }
}
