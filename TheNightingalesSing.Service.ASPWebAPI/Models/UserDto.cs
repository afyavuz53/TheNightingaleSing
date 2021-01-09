using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheNightingalesSing.Service.ASPWebAPI.Models
{
    public class UserDto
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string EMail { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
    }
}
