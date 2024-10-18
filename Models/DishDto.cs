namespace CoNaObiadAPI.Models
{
    public class TagDto
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }

        //it is now a tag that belongs to single dish
        //many-to-many is gone
        public Guid DishId { get; set; }
    }
}
