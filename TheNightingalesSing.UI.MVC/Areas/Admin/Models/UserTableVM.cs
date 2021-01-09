using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheNightingalesSing.UI.MVC.Areas.Admin.Models
{
    public class UserTableVM
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string EMail { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
    }
}
