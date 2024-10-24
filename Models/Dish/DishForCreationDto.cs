using System.ComponentModel.DataAnnotations;

namespace CoNaObiadAPI.Models.Dish
{
    public class DishForCreationDto
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        //required modificator here is only for compiler to know that the field cannot be set to null. It's not validation.
        public required string Name { get; set; }
    }
}
