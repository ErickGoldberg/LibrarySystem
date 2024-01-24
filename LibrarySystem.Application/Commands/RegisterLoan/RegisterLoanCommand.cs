using MediatR;

namespace LibrarySystem.Application.Commands.RegisterLoan
{
    public class RegisterLoanCommand : IRequest<int>
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
    }
}
