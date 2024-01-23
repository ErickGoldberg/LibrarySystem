using LibrarySystem.Application.Commands.DeleteBook;
using LibrarySystem.Application.Commands.RegisterBook;
using LibrarySystem.Application.InputModels;
using LibrarySystem.Application.Services.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.API.Controllers
{
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
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
        public async Task<IActionResult> RegisterBook(RegisterBookCommand registerBookCommand)
        {
            var bookId = await _mediator.Send(registerBookCommand);

            return Created("Book registered: ", bookId);
        }

        [HttpDelete("Book/Delete/{id}")]
        public async Task<IActionResult> DeleteBook(DeleteBookCommand deleteBookCommand)
        {
            await _mediator.Send(deleteBookCommand);

            return NoContent();
        }
    }
}
