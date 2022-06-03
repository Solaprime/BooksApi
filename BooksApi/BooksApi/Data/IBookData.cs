using BooksApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApi.Data
{
   public  interface IBookData
    {
        Task<IEnumerable<Book>> GetBook();
        Task<Book> GetBookById(int Id);

        Task<Book> CreateBook(Book book);
        Task UpdateBook(Book book);
        Task DeleteBook(int Id);
        




        // CRUd

    }
}
