using System;
using System.Collections.Generic;
using System.Text;

namespace TheNightingalesSing.Core.Entity
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreateDate = DateTime.Now;
        }
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
    }
}
