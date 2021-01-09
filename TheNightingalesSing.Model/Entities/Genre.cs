using System;
using System.Collections.Generic;
using System.Text;
using TheNightingalesSing.Core.Entity;

namespace TheNightingalesSing.Model.Entities
{
    public class Genre : BaseEntity
    {
        public Genre()
        {
            IsActive = true;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Album> Album { get; set; }
    }
}
