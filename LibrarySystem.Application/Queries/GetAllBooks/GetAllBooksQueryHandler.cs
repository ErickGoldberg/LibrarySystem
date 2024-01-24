using LibrarySystem.Application.ViewModels;
using LibrarySystem.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Application.Queries.GetAllBooks
{
    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, List<BookViewModel>>
    {
        private readonly LibrarySystemDbContext _dbContext;

        public GetAllBooksQueryHandler(LibrarySystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<BookViewModel>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var books = _dbContext.Books.Select(book => new BookViewModel
            {
                Autor = book.Autor,
                Title = book.Title,
                ISBN = book.ISBN,
                PublicationYear = book.PublicationYear
            });

            return await books.ToListAsync();
        }
    }
}
