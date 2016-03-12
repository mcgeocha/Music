﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Music.Models
{
       public class Album
    {

        public int AlbumID { get; set; }
        [Required(ErrorMessage = "Please enter an Album Title.")]
        public string Title { get; set; }
        [Display(Name = "Genre")]
        public int GenreID { get; set; }
        public Genre Genre { get; set; }
        [Required(ErrorMessage = "Please enter a Price.")]
        [Range(0.01, 100.00, ErrorMessage = "Price must be between 0.01 and 100.00")]
        public decimal Price { get; set; }
        [Display(Name = "Artist")]
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }

    }
}