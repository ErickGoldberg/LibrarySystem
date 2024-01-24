using FluentValidation;
using LibrarySystem.Application.Commands.RegisterLoan;

namespace LibrarySystem.Application.Validators.Loan
{
    public class RegisterLoanValidator : AbstractValidator<RegisterLoanCommand>
    {
        public RegisterLoanValidator()
        {
            RuleFor(i => i.UserId)
                .NotNull()
                .NotEmpty()
                .WithMessage("UserId is required!");

            RuleFor(i => i.BookId)
                .NotNull()
                .NotEmpty()
                .WithMessage("BookId is required!");
        }
    }
}
