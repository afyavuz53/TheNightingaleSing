﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheNightingalesSing.UI.MVC.Models
{
    public class AlbumGenreVM
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public string ArtUrl { get; set; }              
        public string GenreName { get; set; }
    }
}
