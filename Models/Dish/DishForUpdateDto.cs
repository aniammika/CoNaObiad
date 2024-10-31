namespace CoNaObiadAPI.Models.Dish
{
    public class DishForUpdateDto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int PreparationTimeId { get; set; }

        public int SeasonId { get; set; }
    }
}
