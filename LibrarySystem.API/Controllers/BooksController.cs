using LibrarySystem.Application.Commands.DeleteBook;
using LibrarySystem.Application.Commands.RegisterBook;
using LibrarySystem.Application.Queries.GetAllBooks;
using LibrarySystem.Application.Queries.GetBookById;
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
        public async Task<IActionResult> GetAllBooks()
        {
            var query = new GetAllBooksQuery();

            var books = await _mediator.Send(query);

            if(books == null)
                return NotFound("There are no books registered!");

            return Ok(books);
        }

        [HttpGet("Book/{id}")]
        public async Task<IActionResult> GetBook(int id)
        {
            var query = new GetBookByIdQuery { Id = id };
            var book = await _mediator.Send(query);

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
