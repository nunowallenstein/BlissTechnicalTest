using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using BlissQuestions.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BlissQuestions.API.DbContexts
{
    public class QuestionInfoDbContext : DbContext
    {

        public DbSet<QuestionDto> Questions { get; set; } = null!;

        public DbSet<ChoiceDto> Choices { get; set; } = null!;

        public QuestionInfoDbContext(DbContextOptions<QuestionInfoDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestionDto>().HasData(CreateQuestionData());
            modelBuilder.Entity<ChoiceDto>().HasData(CreateChoiceData());
            base.OnModelCreating(modelBuilder);
        }

        private QuestionDto[] CreateQuestionData()
        {
            var res = new List<QuestionDto>();
            for (int i = 1; i <= 10; i++)
            {
                res.Add(new QuestionDto()
                {
                    Id = i,
                    ImageUrl = @"https://dummyimage.com/600x400/000/fff.png&text=question+1+image+(600x400)",
                    ThumbUrl = @"https://dummyimage.com/120x120/000/fff.png&text=question+1+image+(120x120)",
                    PublishedAt = new DateTime(2015, 08, 05, 8, 40, 51, 620),
                    Question = "Favorite programming language?"
                });
            }
            return res.ToArray();
        }
        private ChoiceDto[] CreateChoiceData()
        {
            var res = new List<ChoiceDto>();
            int id = 1;
            for (int i = 1; i <= 10; i++)
            {
                res.Add(new ChoiceDto()
                {
                    Id = id,
                    QuestionId = i,
                    Choice = "Swift",
                    Votes = 2048
                });
                id++;
                res.Add(new ChoiceDto()
                {
                    Id = id,
                    QuestionId = i,
                    Choice = "Python",
                    Votes = 1024
                });
                id++;
                res.Add(new ChoiceDto()
                {
                    Id = id,
                    QuestionId = i,
                    Choice = "Objective-C",
                    Votes = 512
                });
                id++;
                res.Add(new ChoiceDto()
                {
                    Id = id,
                    QuestionId = i,
                    Choice = "Ruby",
                    Votes = 256
                });
                id++;

            }
            return res.ToArray();
        }
    }
}
