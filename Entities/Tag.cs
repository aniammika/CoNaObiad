using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CoNaObiadAPI.Entities
{
    public class Tag
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(60)]
        public required string Name { get; set; }

        public ICollection<Dish> Dishes { get; set; } = new List<Dish>();

        [SetsRequiredMembers]
        public Tag(Guid id, string name)
        {
            Id = id;   
            Name = name;
        }
    }
}
