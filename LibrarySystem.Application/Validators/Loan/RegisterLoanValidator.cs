using FluentValidation;
using LibrarySystem.Application.InputModels;
using LibrarySystem.Application.Validators.Helper;

namespace LibrarySystem.Application.Validators.Loan
{
    public class RegisterLoanValidator : AbstractValidator<RegisterLoanInputModel>
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
