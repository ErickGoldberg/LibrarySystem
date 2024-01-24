using LibrarySystem.Core.DTOs;
using MediatR;

namespace LibrarySystem.Application.Queries.GetBookById
{
    public class GetBookByIdQuery : IRequest<BookDto>
    {
        public int Id { get; set; }
    }
}
