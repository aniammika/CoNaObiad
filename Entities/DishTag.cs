﻿using System.ComponentModel.DataAnnotations;

namespace CoNaObiadAPI.Entities
{
    public class DishTag
    {
        [Key]
        public int Id { get; set; }

        public int DishesId { get; set; }

        public int TagsId { get; set; }
    }
}
