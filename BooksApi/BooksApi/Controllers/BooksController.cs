using BooksApi.Data;
using BooksApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // Configer with swagger
        // put, post not working on Poastman
        // asp.net will converts things into Json for us 
        private readonly IBookData _bookData;
        public BooksController(IBookData bookData)
        {
            _bookData = bookData;
        }
        [HttpGet]
        public async Task<IEnumerable<Book>> GetBook()
        {
            return await _bookData.GetBook();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            return await _bookData.GetBookById(id);
        }
        
        [HttpPost]
        public async Task<ActionResult<Book>>PostBooks([FromBody] Book book)
        {
            var newBook = await _bookData.CreateBook(book);
            return Ok();
            //return CreatedAtAction(nameof(GetBook), new { Id = 10, Name = "Sola", AuthorName = "PHS 115" });

        }

        [HttpPut]
        public  async Task<ActionResult> PutBooks(int id, [FromBody]Book book)
        {
            if (id!= book.Id)
            {
                return BadRequest();
            }
            await _bookData.UpdateBook(book);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var bookToDelete = await _bookData.GetBookById(id);
            if (bookToDelete == null)
            {
                return BadRequest();
            }
            return NoContent();
        }

    }
}
