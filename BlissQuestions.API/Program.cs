using BlissQuestions.API.DbContexts;
using BlissQuestions.API.Utilities;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using BlissQuestions.API.Services;
using FluentValidation;
using BlissQuestions.API.Validators;

namespace BlissQuestions.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers().AddJsonOptions(x =>
            {
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                x.JsonSerializerOptions.PropertyNamingPolicy = SnakeCaseNamingPolicy.Instance;
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IQuestionsRepository, QuestionsRepository>();
            builder.Services.AddSingleton<IEmailService, EmailService>();
            builder.Services.AddDbContext<QuestionInfoDbContext>(options => options.UseSqlite(builder.Configuration["ConnectionStrings:QuestionsDBConnectionString"]));
            builder.Services.AddHealthChecks().AddDbContextCheck<QuestionInfoDbContext>();
            builder.Services.AddValidatorsFromAssemblyContaining<QuestionForUpdateValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<QuestionForCreationValidator>();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHealthChecks("api/health");
                endpoints.MapControllers();
            });
            app.Run();
        }
    }
}