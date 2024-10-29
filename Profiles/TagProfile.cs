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
            CreateMap<TagForCreationDto, Tag>();
        }
    }
}
