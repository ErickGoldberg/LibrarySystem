using LibrarySystem.Application.InputModels;
using LibrarySystem.Application.Services.Interfaces;
using LibrarySystem.Core.Entities;
using LibrarySystem.Infrastructure.Persistence;

namespace LibrarySystem.Application.Services.Implementations
{
    public class UserService
    {
        private readonly LibrarySystemDbContext _dbContext;

        public UserService(LibrarySystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void RegisterUser(CreateUserInputModel userInputModel)
        {
            var user = new User(userInputModel.Name, userInputModel.Mail);

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }
    }
}
