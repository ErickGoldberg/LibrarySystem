using LibrarySystem.Core.Entities;
using LibrarySystem.Infrastructure.Persistence;
using MediatR;

namespace LibrarySystem.Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly LibrarySystemDbContext _dbContext;

        public CreateUserCommandHandler(LibrarySystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User(request.Name, request.Mail);

            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }


    }
}