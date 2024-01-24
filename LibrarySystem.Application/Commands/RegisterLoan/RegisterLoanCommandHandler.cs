using LibrarySystem.Core.Entities;
using LibrarySystem.Core.Repositories;
using LibrarySystem.Infrastructure.Persistence;
using LibrarySystem.Infrastructure.Persistence.Repositories;
using MediatR;

namespace LibrarySystem.Application.Commands.RegisterLoan
{
    public class RegisterLoanCommandHandler : IRequestHandler<RegisterLoanCommand, int>
    {
        private readonly ILoanRepository _loanRepository;

        public RegisterLoanCommandHandler(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public async Task<int> Handle(RegisterLoanCommand request, CancellationToken cancellationToken)
        {
            var loan = new Loan(request.UserId, request.BookId);

            return await _loanRepository.RegisterLoanAsync(loan);
        }
    }
}
