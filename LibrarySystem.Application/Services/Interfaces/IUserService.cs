using LibrarySystem.Application.InputModels;
using LibrarySystem.Core.Entities;

namespace LibrarySystem.Application.Services.Interfaces
{
    public interface IUserService
    {
        void RegisterUser(CreateUserInputModel user);
    }
}
