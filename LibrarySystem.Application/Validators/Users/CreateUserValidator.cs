using FluentValidation;
using LibrarySystem.Application.Commands.CreateUser;
using LibrarySystem.Application.Validators.Helper;

namespace LibrarySystem.Application.Validators.Users
{
    public class CreateUserValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserValidator()
        {
            RuleFor(i => i.Mail)
                .EmailAddress()
                .WithMessage("Send a valid mail!");

            RuleFor(i => i.Name)
                .Must(ValidatorsHelper.IsAlphaOnly) 
                .WithMessage("Name can only contain letters!")
                .MaximumLength(20)
                .MinimumLength(3)
                .WithMessage("Name is required and must have 3-20 characters!");
        }
    }
}
