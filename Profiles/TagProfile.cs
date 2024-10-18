using AutoMapper;
using CoNaObiadAPI.Entities;
using CoNaObiadAPI.Models;

namespace CoNaObiadAPI.Profiles
{
    public class TagProfile : Profile
    {
        public TagProfile()
        {
            CreateMap<Tag, TagDto>().
                ForMember(d => d.DishId, o => o.MapFrom(s => s.Dishes.First().Id));
        }
    }
}
