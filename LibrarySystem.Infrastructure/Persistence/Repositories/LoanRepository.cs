using LibrarySystem.Core.Entities;
using LibrarySystem.Core.Repositories;

namespace LibrarySystem.Infrastructure.Persistence.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly LibrarySystemDbContext _dbContext;

        public LoanRepository(LibrarySystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> RegisterLoanAsync(Loan loan)
        {
            await _dbContext.Loan.AddAsync(loan);
            await _dbContext.SaveChangesAsync();

            return loan.Id;
        }
    }
}
