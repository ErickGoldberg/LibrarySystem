using Azure.Core;
using LibrarySystem.Core.DTOs;
using LibrarySystem.Core.Entities;
using LibrarySystem.Core.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Infrastructure.Persistence.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibrarySystemDbContext _dbContext;

        public BookRepository(LibrarySystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<BookDto>> GetAllAsync()
        {
            var books = await _dbContext.Books.Select(book => new BookDto
            {
                Autor = book.Autor,
                Title = book.Title,
                ISBN = book.ISBN,
                PublicationYear = book.PublicationYear
            }).ToListAsync() ?? new List<BookDto>();

            return books;
        }

        public async Task<BookDto> GetByIdAsync(int id)
        {
            var query = await _dbContext.Books.SingleOrDefaultAsync(i => i.Id == id);

            var book = query != null ? new BookDto
            {
                Autor = query.Autor,
                Title = query.Title,
                ISBN = query.ISBN,
                PublicationYear = query.PublicationYear
            } : null;

            return book;
        }

        public async Task<int> RegisterAsync(BookDto bookDto)
        {
            var book = new Book(bookDto.Title,
                                bookDto.Autor,
                                bookDto.ISBN,
                                bookDto.PublicationYear);

            await _dbContext.Books.AddAsync(book);
            await _dbContext.SaveChangesAsync();

            return book.Id;
        }

        public async Task DeleteAsync(Book book)
        {
            if (book != null)
            {
                _dbContext.Books.Remove(book);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
