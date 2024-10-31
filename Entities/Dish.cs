using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace CoNaObiadAPI.Entities
{
    public class Dish
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Name { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        //indicating a foreign key is not necessary
        [ForeignKey("SeasonId")]
        public Season? Season { get; set; }

        //not necessary
        public int SeasonId { get; set; }

        [ForeignKey("PreparationTimeId")]
        public PreparationTime? PreparationTime { get; set; }

        public int PreparationTimeId { get; set; }

        public ICollection<Tag> Tags { get; set; } = new List<Tag>();

        public Dish()
        {
        }

        public Dish(string name, Season season)
        {
            Name = name;
            Season = season;
        }

        [SetsRequiredMembers]
        public Dish(string name, string description, Season season)
        {
            Name = name;
            Description = description;
            Season = season;
        }
    }
}
