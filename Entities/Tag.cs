using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CoNaObiadAPI.Entities
{
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        public required string Name { get; set; }

        public ICollection<Dish> Dishes { get; set; } = new List<Dish>();

        public Tag() { }
        
        [SetsRequiredMembers]
        public Tag(string name)
        { 
            Name = name;
        }
    }
}
