using BlissQuestions.API.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace BlissQuestions.API.Validators
{
    public class QuestionForUpdateValidator : AbstractValidator<QuestionForUpdateDto>
    {
        public QuestionForUpdateValidator() 
        {
            RuleFor(question => question.Question).NotNull().NotEmpty();
            RuleFor(question => question.PublishedAt).NotNull().NotEmpty();
            RuleFor(question => question.Choices).NotNull().NotEmpty();
            RuleForEach(question => question.Choices).SetValidator(new ChoiceValidator());
            RuleFor(question => question.ImageUrl).NotNull().NotEmpty();
            RuleFor(question => question.ThumbUrl).NotNull().NotEmpty();
        }
    }
}
