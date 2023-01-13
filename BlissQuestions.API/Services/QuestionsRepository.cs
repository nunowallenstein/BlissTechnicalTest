using BlissQuestions.API.DbContexts;
using BlissQuestions.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlissQuestions.API.Services
{

    public class QuestionsRepository : IQuestionsRepository
    {
        private readonly QuestionInfoDbContext _context;

        public QuestionsRepository(QuestionInfoDbContext context)
        {
            _context = context;
        }

        public async Task<QuestionEntity?> GetQuestionAsync(int id)
        {
            return await _context.Questions.Where(q => q.Id == id).Include(q => q.Choices).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<QuestionEntity?>> GetQuesionsAsync(int? limit, int? offset, string? filter)
        {
            var collection = _context.Questions as IQueryable<QuestionEntity>;
            if (!string.IsNullOrEmpty(filter))
            {
                filter = filter.Trim();
                collection = collection.Where(q => q.Question!.Contains(filter));
            }
            if (offset != null)
            {
                collection = collection.Skip((int)offset);
            }
            if (limit != null)
            {
                collection = collection.Take((int)limit);
            }
            return await collection.Include(q => q.Choices).ToListAsync();

        }

        public void AddQuestion(QuestionEntity questionEntity)
        {
            _context.Questions.Add(questionEntity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }

        public async Task<bool> HasQuestionAsync(int id)
        {
            return await _context.Questions.AnyAsync(q => q.Id == id);
        }
    }
}
