using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApi.Model
{
    public class TestDatacs
    {
        private readonly BookContext _bookContext;
        public TestDatacs(BookContext bookContext)
        {
            _bookContext = bookContext;
        }
      
        Book Books = new Book() {Id=1, AuthorName="Oluwasola", Name="How to Be Rich" };
       

    }
}
