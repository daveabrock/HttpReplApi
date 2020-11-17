﻿using System.ComponentModel.DataAnnotations;

namespace HttpReplApi.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int ReleaseYear { get; set; }

    }
}