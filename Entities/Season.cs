using System.ComponentModel.DataAnnotations;

namespace CoNaObiadAPI.Entities
{
    public class Season
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Dish> Dishes { get; } = new List<Dish>();
    }
}
