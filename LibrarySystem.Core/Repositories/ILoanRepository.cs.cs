using LibrarySystem.Core.Entities;

namespace LibrarySystem.Core.Repositories
{
    public interface ILoanRepository
    {
        Task<int> RegisterLoanAsync(Loan loan);
    }
}
