using LibrarySystem.Core.DTOs;
using LibrarySystem.Core.Entities;
using LibrarySystem.Core.Repositories;
using LibrarySystem.Infrastructure.Persistence;
using MediatR;

namespace LibrarySystem.Application.Commands.RegisterBook
{
    public class RegisterBookCommandHandler : IRequestHandler<RegisterBookCommand, int>
    {
        private readonly IBookRepository _bookRepository;

        public RegisterBookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<int> Handle(RegisterBookCommand request, CancellationToken cancellationToken)
        {
            var book = new BookDto()
            {
                Title = request.Title,
                Autor = request.Autor,
                ISBN = request.ISBN,
                PublicationYear = request.PublicationYear
            };

            return await _bookRepository.RegisterAsync(book);
        }
    }
}
