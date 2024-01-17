﻿using LibrarySystem.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _booksService;

        public BooksController(IBookService booksService)
        {
            _booksService = booksService;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var books = _booksService.GetAllBooks();

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            var books = _booksService.GetBookById(id);

            return Ok();
        }

        [HttpPost("{id}")]
        public IActionResult RegisterBook(int id)
        {
            _booksService.RegisterBook(id);

            return Created("Book registered: ", id);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            _booksService.DeleteBook(id);

            return NoContent();
        }
    }
}