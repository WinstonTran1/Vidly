﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }
        public DateTime? DateAdded { get; set; }

        [Required]
        [Range(1, 100)]
        [Display(Name = "Number in Stock")]
        public int NumberInStock { get; set; }
        public int NumberAvailable { get; set; }
    }
}