using BlissQuestions.API.Models;
using FluentValidation;

namespace BlissQuestions.API.Validators
{
    public class QuestionForCreationValidator : AbstractValidator<QuestionForCreationDto>
    {
        public QuestionForCreationValidator()
        {
            RuleFor(question => question.Question).NotNull().NotEmpty();
            RuleFor(question => question.PublishedAt).NotNull().NotEmpty();
            RuleFor(question => question.Choices).NotNull().NotEmpty();
            RuleFor(question => question.ImageUrl).NotNull().NotEmpty();
            RuleFor(question => question.ThumbUrl).NotNull().NotEmpty();
        }
    }
}
