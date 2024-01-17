using LibrarySystem.Application.InputModels;
using LibrarySystem.Application.Services.Interfaces;
using LibrarySystem.Core.Entities;

namespace LibrarySystem.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        public void RegisterUser(CreateUserInputModel userInputModel)
        {
            var user = new User(userInputModel.Name, userInputModel.Mail);

            // add to database te "user"
        }
    }
}
