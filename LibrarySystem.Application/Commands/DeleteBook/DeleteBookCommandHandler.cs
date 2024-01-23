using LibrarySystem.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Application.Commands.DeleteBook
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand>
    {
        private readonly LibrarySystemDbContext _dbContext;

        public DeleteBookCommandHandler(LibrarySystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var book = _dbContext.Books.SingleOrDefault(i => i.Id == request.Id);

            if (book != null)
            {
                _dbContext.Books.Remove(book);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
