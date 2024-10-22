using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace CoNaObiadAPI.Entities
{
    public class Dish
    {
        [Key]   
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Name { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public ICollection<Tag> Tags { get; set; } = new List<Tag>();

        public Dish()
        {
        }

        public Dish(string name, string description)
        {
            Name = name;
            Description = description;
        }

        [SetsRequiredMembers]
        public Dish(Guid id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;

        }
    }
}
