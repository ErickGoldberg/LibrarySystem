using LibrarySystem.Application.ViewModels;
using LibrarySystem.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Application.Queries.GetBookById
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, BookViewModel>
    {
        private readonly LibrarySystemDbContext _dbContext;

        public GetBookByIdQueryHandler(LibrarySystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<BookViewModel> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var query = await _dbContext.Books.SingleOrDefaultAsync(i => i.Id == request.Id);

            var book = query != null ? new BookViewModel
            {
                Autor = query.Autor,
                Title = query.Title,
                ISBN = query.ISBN,
                PublicationYear = query.PublicationYear
            } : null;

            return book;
        }
    }
}
