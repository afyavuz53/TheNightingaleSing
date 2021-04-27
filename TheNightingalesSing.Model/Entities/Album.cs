using System;
using System.Collections.Generic;
using System.Text;
using TheNightingalesSing.Core.Entity;

namespace TheNightingalesSing.Model.Entities
{
    public class Album:BaseEntity
    {
        public Album()
        {
            Continued = true;
            Discount = false;
            IsActive = true;
        }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ArtUrl { get; set; }
        public short Stock { get; set; }
        public bool Continued { get; set; }
        public bool Discount { get; set; }
        public int ArtistID { get; set; }
        public int GenreID { get; set; }
        public Artist Artist { get; set; }
        public Genre Genre { get; set; }
        public ICollection<OrderDetail> OrderDetail { get; set; }
        public string ReDate { get; set; }
    }
}
