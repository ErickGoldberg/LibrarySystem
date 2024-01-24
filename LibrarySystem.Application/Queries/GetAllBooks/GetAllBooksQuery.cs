using LibrarySystem.Application.ViewModels;
using MediatR;

namespace LibrarySystem.Application.Queries.GetAllBooks
{
    public class GetAllBooksQuery : IRequest<List<BookViewModel>>
    {
        // Ignore
    }
}
