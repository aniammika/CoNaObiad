using CoNaObiadAPI.Models.Dish;

namespace CoNaObiadAPI.Models.Tag
{
    public class TagWithDishesDto
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public ICollection<DishDto> RelatedDishes { get; set; } = new List<DishDto>();
    }
}
