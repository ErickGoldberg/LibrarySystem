using LibrarySystem.Core.Entities;

namespace LibrarySystem.Core.Repositories
{
    public interface IUserRepository
    {
        Task RegisterUserAsync(User user);
    }
}
