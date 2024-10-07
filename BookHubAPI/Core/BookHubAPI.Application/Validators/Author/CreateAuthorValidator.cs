using BookHubAPI.Application.Features.Commands.Author.CreateAuthor;
using FluentValidation;

namespace BookHubAPI.Application.Validators;

public class CreateAuthorValidator : AbstractValidator<CreateAuthorCommandRequest>
{
    public CreateAuthorValidator()
    {
        RuleFor(x => x.FirstName)
            .NotNull().NotEmpty().WithMessage("Firstname cannot be empty.")
            .Length(3, 20).WithMessage("Firstname must be between 3 and 20 characters.");

        RuleFor(x => x.LastName)
             .NotNull().NotEmpty().WithMessage("Lastname cannot be empty.")
            .Length(3, 20).WithMessage("Lastname must be between 3 and 20 characters.");
    }

}
