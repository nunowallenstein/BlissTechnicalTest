using BlissQuestions.API.Models;
using FluentValidation;

namespace BlissQuestions.API.Validators
{
    public class ChoiceValidator : AbstractValidator<ChoiceDto>
    {
        public ChoiceValidator() 
        {
            RuleFor(choice=>choice.Choice).NotNull().NotEmpty();
            RuleFor(choice => choice.Votes).NotNull();
        }
    }
}
