using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheNightingalesSing.UI.MVC.Areas.Admin.Models
{
    public class AlbumTableVM
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        
        public short Stock { get; set; }
        public bool Continued { get; set; }
        public bool Discount { get; set; }
        public string ArtistName { get; set; }
        public string GenreName { get; set; }
        public bool IsActive { get; set; }
    }
}
