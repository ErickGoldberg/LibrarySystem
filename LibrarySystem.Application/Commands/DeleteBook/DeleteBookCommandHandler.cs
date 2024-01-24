using LibrarySystem.Core.Entities;
using LibrarySystem.Core.Repositories;
using LibrarySystem.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Application.Commands.DeleteBook
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand>
    {
        private readonly IBookRepository _bookRepository;

        public DeleteBookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var bookDto = await _bookRepository.GetByIdAsync(request.Id);

            var book = new Book(bookDto.Title, bookDto.Autor, bookDto.ISBN, bookDto.PublicationYear){};

            _bookRepository.DeleteAsync(book);
        }
    }
}
