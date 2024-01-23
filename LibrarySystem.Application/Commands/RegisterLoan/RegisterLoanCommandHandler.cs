using LibrarySystem.Application.InputModels;
using LibrarySystem.Core.Entities;
using LibrarySystem.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Application.Commands.RegisterLoan
{
    public class RegisterLoanCommandHandler : IRequestHandler<RegisterLoanCommand, int>
    {
        private readonly LibrarySystemDbContext _dbContext;

        public RegisterLoanCommandHandler(LibrarySystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(RegisterLoanCommand request, CancellationToken cancellationToken)
        {
            var loan = new Loan(request.UserId, request.BookId);

            await _dbContext.Loan.AddAsync(loan);
            await _dbContext.SaveChangesAsync();

            return loan.Id;
        }
    }
}
