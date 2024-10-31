namespace CoNaObiadAPI.Models.Dish
{
    public class DishDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int SeasonId { get; set; }

        public int PreparationTimeId { get; set; }
    }
}
