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
            CreateMap<string, ChoiceEntity>().ForMember(dest => dest.Choice, opts => opts.MapFrom(x => x))
                                             .ForMember(dest => dest.Votes, opts => opts.MapFrom(x => 0));
        }
    }
}
