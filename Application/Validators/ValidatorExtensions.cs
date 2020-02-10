using FluentValidation;

namespace Application.Validators
{
    public static class ValidatorExtensions
    {
        public static IRuleBuilder<T, string> Password<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            var options = ruleBuilder
            .NotEmpty()
            .MinimumLength(6).WithMessage("Password must be at least 6 characters.")
            .Matches("[A-Z]").WithMessage("Passowrd must containt 1 uppercase character")
            .Matches("[a-z]").WithMessage("Password must contain at lest 1 lowercase character")
            .Matches("[0-9]").WithMessage("Password must contain number")
            .Matches("[a-zA-Z0-9]").WithMessage("Password must containt non alphanumeric");
            
            return options;

        }

    }
}