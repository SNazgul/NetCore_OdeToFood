﻿using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Entities
{
    public enum CuisineType
    {
        None,
        Italian,
        French,
        American
    }

    public class Restaurant
    {
        public int Id { get; set; }

        [Required, MaxLength(80)]
        [Display(Name="Restaurant Name")]
        //[DataType(DataType.Password)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
