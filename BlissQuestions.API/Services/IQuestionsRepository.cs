using BlissQuestions.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlissQuestions.API.Services
{
    public interface IQuestionsRepository
    {
        Task<QuestionEntity?> GetQuestionAsync(int id);
        Task<IEnumerable<QuestionEntity?>> GetQuesionsAsync(int? limit, int? offset, string? filter);

        void AddQuestion(QuestionEntity questionDto);
        Task<bool> SaveChangesAsync();

        Task<bool> HasQuestionAsync(int id);
    }
}
