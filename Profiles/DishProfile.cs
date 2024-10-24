using AutoMapper;
using CoNaObiadAPI.Entities;
using CoNaObiadAPI.Models.Dish;

namespace CoNaObiadAPI.Profiles
{
    public class DishProfile : Profile
    {
        public DishProfile()
        {
            CreateMap<Dish, DishDto>();
            CreateMap<DishForCreationDto, Dish>();
            CreateMap<DishForUpdateDto, Dish>();
        }
    }
}
