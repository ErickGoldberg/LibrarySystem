using LibrarySystem.Core.DTOs;
using MediatR;

namespace LibrarySystem.Application.Queries.GetAllBooks
{
    public class GetAllBooksQuery : IRequest<List<BookDto>>
    {
        // Ignore
    }
}
