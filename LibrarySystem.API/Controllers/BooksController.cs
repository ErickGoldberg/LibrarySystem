using LibrarySystem.Application.InputModels;
using LibrarySystem.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.API.Controllers
{
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _booksService;

        public BooksController(IBookService booksService)
        {
            _booksService = booksService;
        }

        [HttpGet("Books")]
        public IActionResult GetAllBooks()
        {
            var books = _booksService.GetAllBooks();

            if(books == null)
                return NotFound("There are no books registered!");

            return Ok(books);
        }

        [HttpGet("Book/{id}")]
        public IActionResult GetBook(int id)
        {
            var book = _booksService.GetBookById(id);

            if (book == null)
                return BadRequest("Id not found!");

            return Ok(book);
        }

        [HttpPost("Book/Register")]
        public IActionResult RegisterBook(RegisterBookInputModel registerBookInputModel)
        {
            var bookId = _booksService.RegisterBook(registerBookInputModel);

            return Created("Book registered: ", bookId);
        }

        [HttpDelete("Book/Delete/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _booksService.DeleteBook(id);

            return NoContent();
        }
    }
}
