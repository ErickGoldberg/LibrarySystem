using LibrarySystem.Application.ViewModels;
using MediatR;

namespace LibrarySystem.Application.Queries.GetBookById
{
    public class GetBookByIdQuery : IRequest<BookViewModel>
    {
        public int Id { get; set; }
    }
}
