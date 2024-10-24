using AutoMapper;
using CoNaObiadAPI.Entities;
using CoNaObiadAPI.Models;
using CoNaObiadAPI.Models.Tag;

namespace CoNaObiadAPI.Profiles
{
    public class TagProfile : Profile
    {
        public TagProfile()
        {
            CreateMap<Tag, TagDto>();
            CreateMap<Tag, TagWithDishesDto>().
                ForMember(d => d.RelatedDishes, o => o.MapFrom(s => s.Dishes.ToArray()));
            CreateMap<TagForCreationDto, Tag>();
        }
    }
}
