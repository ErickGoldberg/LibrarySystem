using FluentValidation;
using LibrarySystem.Application.Commands.RegisterBook;
using LibrarySystem.Application.Validators.Helper;

namespace LibrarySystem.Application.Validators.Books
{
    public class RegisterBookValidator : AbstractValidator<RegisterBookCommand>
    {
        public RegisterBookValidator()
        {
            RuleFor(i => i.Autor)
                .Must(ValidatorsHelper.IsAlphaOnly)
                .WithMessage("Name can only contain letters!")
                .MaximumLength(20)
                .MinimumLength(3)
                .WithMessage("Autor name is required and must have 3-20 characters!");

            RuleFor(i => i.Title)
                .MaximumLength(60)
                .MinimumLength(2)
                .WithMessage("Title is required and must have 2-60 characters!"); ;

            RuleFor(i => i.ISBN)
                .NotEmpty()
                .NotNull()
                .WithMessage("ISBN is required!")
                .Must(ValidatorsHelper.IsValidISBN)
                .WithMessage("Invalid ISBN format. Please enter a valid ISBN.");

            RuleFor(i => i.PublicationYear)
                .NotEmpty()
                .NotNull()
                .WithMessage("Publication year is required!")
                .Must(ValidatorsHelper.IsValidPublicationYear)
                .WithMessage("Invalid publication year. Please enter a year between 1900 and the current year.");

        }
    }
}
