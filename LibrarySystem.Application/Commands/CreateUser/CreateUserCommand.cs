using MediatR;

namespace LibrarySystem.Application.Commands.CreateUser
{
    public class CreateUserCommand : IRequest
    {
        public string Name { get; set; }
        public string Mail { get; set; }
    }
}
