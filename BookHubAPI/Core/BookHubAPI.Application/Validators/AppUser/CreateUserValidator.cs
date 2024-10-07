using BookHubAPI.Application.Features.Commands.AppUser.CreateUser;
using FluentValidation;

namespace BookHubAPI.Application.Validators.AppUser;

public class CreateUserValidator : AbstractValidator<CreateUserCommandRequest>
{
    public CreateUserValidator()
    {
        RuleFor(x => x.Fullname)
            .NotNull().NotEmpty().WithMessage("Full name is required.");

        RuleFor(x => x.Username)
            .NotNull().NotEmpty().WithMessage("Username is required.")
            .Length(3, 20).WithMessage("Username must be between 3 and 20 characters.");

        RuleFor(x => x.Email)
            .NotNull().NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Invalid email format.");

        RuleFor(x => x.Password)
            .NotNull().NotEmpty().WithMessage("Password is required.")
            .MinimumLength(4).WithMessage("Password must be at least 4 characters long.");
        //.Matches("[A-Z]").WithMessage("Password must contain at least one uppercase letter.")
        //.Matches("[a-z]").WithMessage("Password must contain at least one lowercase letter.")
        //.Matches("[0-9]").WithMessage("Password must contain at least one digit.")
        //.Matches(@"[^\w]").WithMessage("Password must contain at least one special character.");

        RuleFor(x => x.PasswordConfirm)
            .NotNull().NotEmpty().WithMessage("Password confirmation is required.")
            .Equal(x => x.Password).WithMessage("Passwords do not match.");
    }
}
