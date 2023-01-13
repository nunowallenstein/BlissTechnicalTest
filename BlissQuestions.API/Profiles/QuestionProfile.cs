using AutoMapper;
using BlissQuestions.API.Entities;
using BlissQuestions.API.Models;
using System;

namespace BlissQuestions.API.Profiles
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile() 
        {
            CreateMap<QuestionForUpdateDto, QuestionEntity>();
            CreateMap<QuestionEntity, QuestionDto>();
            CreateMap<QuestionForCreationDto, QuestionEntity>();
        }
    }
}
