using BlissQuestions.API.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace BlissQuestions.API.Validators
{
    public class QuestionValidator : AbstractValidator<QuestionForCreationDto>
    {
        public QuestionValidator() 
        {
            RuleFor(question => question.Question).NotNull().NotEmpty();
            RuleFor(question => question.PublishedAt).NotNull().NotEmpty();
            RuleForEach(question => question.Choices).SetValidator(new ChoiceValidator());
            RuleFor(question => question.ImageUrl).NotNull().NotEmpty();
            RuleFor(question => question.ThumbUrl).NotNull().NotEmpty();
        }
    }
}
