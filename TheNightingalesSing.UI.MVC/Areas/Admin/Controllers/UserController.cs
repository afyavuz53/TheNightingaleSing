using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheNightingalesSing.UI.MVC.Areas.Admin.Models;

namespace TheNightingalesSing.UI.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoadUserTable([FromBody] List<UserTableVM> users)
        {
            if (users == null)
            {
                ViewBag.Message = "Kullanıcı bulunamadı.";
                return RedirectToAction("Index", "Admin", new { area = "Admin" });
            }
            return PartialView("_userTableItem", users);
        }
    }
}
