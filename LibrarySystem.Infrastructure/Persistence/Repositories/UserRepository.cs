using LibrarySystem.Core.Entities;
using LibrarySystem.Core.Repositories;

namespace LibrarySystem.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly LibrarySystemDbContext _dbContext;

        public UserRepository(LibrarySystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task RegisterUserAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }
    }
}
