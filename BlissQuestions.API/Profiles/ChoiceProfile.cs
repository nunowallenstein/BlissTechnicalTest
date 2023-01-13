using AutoMapper;
using BlissQuestions.API.Entities;
using BlissQuestions.API.Models;

namespace BlissQuestions.API.Profiles
{
    public class ChoiceProfile : Profile
    {
        public ChoiceProfile()
        {
            CreateMap<ChoiceDto, ChoiceEntity>().ReverseMap();
        }
    }
}
