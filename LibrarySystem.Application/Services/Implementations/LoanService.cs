using LibrarySystem.Application.InputModels;
using LibrarySystem.Application.Services.Interfaces;
using LibrarySystem.Core.Entities;
using LibrarySystem.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Application.Services.Implementations
{
    public class LoanService : ILoanService
    {
        private readonly LibrarySystemDbContext _dbContext;

        public LoanService(LibrarySystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int RegisterLoan(RegisterLoanInputModel registerLoanInputModel)
        {
            var loan = new Loan(registerLoanInputModel.UserId, registerLoanInputModel.BookId);

            _dbContext.Loan.Add(loan);
            _dbContext.SaveChanges();

            return loan.Id;
        }
    }
}
