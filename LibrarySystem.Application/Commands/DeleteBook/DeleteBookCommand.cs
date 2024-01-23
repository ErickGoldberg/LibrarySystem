using MediatR;

namespace LibrarySystem.Application.Commands.DeleteBook
{
    public class DeleteBookCommand : IRequest
    {
        public int Id { get; set; }
    }
}
