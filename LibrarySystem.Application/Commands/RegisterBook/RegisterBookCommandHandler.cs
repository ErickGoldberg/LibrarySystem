using LibrarySystem.Application.InputModels;
using LibrarySystem.Core.Entities;
using LibrarySystem.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Application.Commands.RegisterBook
{
    public class RegisterBookCommandHandler : IRequestHandler<RegisterBookCommand, int>
    {
        private readonly LibrarySystemDbContext _dbContext;

        public RegisterBookCommandHandler(LibrarySystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(RegisterBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book(request.Title,
                                request.Autor,
                                request.ISBN,
                                request.PublicationYear);

            await _dbContext.Books.AddAsync(book);
            await _dbContext.SaveChangesAsync();

            return book.Id;
        }
    }
}
