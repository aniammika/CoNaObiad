using CoNaObiadAPI.Models.Dish;

namespace CoNaObiadAPI.Models.Tag
{
    public class TagDto
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }
    }
}
