using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheNightingalesSing.Service.ASPWebAPI.Models
{
    public class AlbumInsDto
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public string ArtUrl { get; set; }
        public decimal Price { get; set; }
        public short Stock { get; set; }
        public int ArtistID { get; set; }
        public int GenreID { get; set; }
    }
}
