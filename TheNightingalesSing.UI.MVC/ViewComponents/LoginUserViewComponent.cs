using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheNightingalesSing.UI.MVC.Models;

namespace TheNightingalesSing.UI.MVC.ViewComponents
{
    public class LoginUserViewComponent : ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            LoginUser loginUser = new LoginUser()
            {
                UserName = HttpContext.User.Identity.Name
            };

            return View(loginUser);
        }
    }
}
