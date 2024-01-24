using LibrarySystem.Core.DTOs;
using LibrarySystem.Core.Repositories;
using MediatR;

namespace LibrarySystem.Application.Queries.GetAllBooks
{
    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, List<BookDto>>
    {
        private readonly IBookRepository _bookRepository;

        public GetAllBooksQueryHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<List<BookDto>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            return await _bookRepository.GetAllAsync();
        }
    }
}
