using BookHubAPI.Application.ViewModels.Author;
using FluentValidation;

namespace BookHubAPI.Application.Validators.Author
{
    public class CreateAuthorValidator:AbstractValidator<CreateAuthorVM>
    {
        public CreateAuthorValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Firstname can not be empty")
                .MinimumLength(3)
                .MaximumLength(20)
                    .WithMessage("Firstname must be between 3-20 characters.");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lastname can not be empty")
                .MinimumLength(3)
                .MaximumLength(20)
                    .WithMessage("Lastname must be between 3-20 characters");
        }
    }
}
