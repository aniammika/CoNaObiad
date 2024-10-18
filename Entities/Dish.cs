using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CoNaObiadAPI.Entities
{
    public class Dish
    {
        [Key]   
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Name { get; set; }

        public ICollection<Tag> Tags { get; set; } = new List<Tag>();

        [SetsRequiredMembers]
        public Dish(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
