using AutoMapper;
using CoNaObiadAPI.Entities;
using CoNaObiadAPI.Models;

namespace CoNaObiadAPI.Profiles
{
    public class DishProfile : Profile
    {
        public DishProfile()
        {
            CreateMap<Dish, DishDto>();
        }
    }
}
