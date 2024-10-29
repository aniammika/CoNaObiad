using AutoMapper;
using CoNaObiadAPI.Entities;
using CoNaObiadAPI.Models.DishTag;
using CoNaObiadAPI.Models.Tag;

namespace CoNaObiadAPI.Profiles
{
    public class DishTagProfile : Profile
    {
        public DishTagProfile()
        {
            CreateMap<DishTag, DishTagDto>();
        }
    }
}