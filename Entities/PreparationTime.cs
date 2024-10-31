using System.ComponentModel.DataAnnotations;

namespace CoNaObiadAPI.Entities
{
    public class PreparationTime
    {
        [Key]
        public int Id { get; set; }

        public string Time { get; set; }

        public ICollection<Dish> Dishes { get; } = new List<Dish>();
    }
}
