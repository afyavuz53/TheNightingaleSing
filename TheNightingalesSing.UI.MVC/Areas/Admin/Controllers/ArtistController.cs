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
    public class ArtistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoadTableArtist([FromBody]List<ArtistTableVM> tableVMs)
        {
            if (tableVMs==null)
            {
                ViewBag.Message = "Artist bulunamadı.";
                return RedirectToAction("Index", "Admin", new { area = "Admin" });
            }
            return PartialView("_artistTableItem", tableVMs);
            
        }
        public IActionResult Insert()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
    }
}
