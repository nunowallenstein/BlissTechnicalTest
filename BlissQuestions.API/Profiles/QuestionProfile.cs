﻿using AutoMapper;
using BlissQuestions.API.Entities;
using BlissQuestions.API.Models;
using System;

namespace BlissQuestions.API.Profiles
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile() 
        {
            CreateMap<QuestionForCreationDto, QuestionEntity>().ForMember(dest=>dest.PublishedAt,opts=>opts.MapFrom(src=>src.PublishedAt==default?DateTime.UtcNow:src.PublishedAt));
            CreateMap<QuestionEntity, QuestionDto>();
        }
    }
}