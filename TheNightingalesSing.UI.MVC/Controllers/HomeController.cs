using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheNightingalesSing.UI.MVC.Models;

namespace TheNightingalesSing.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SingleAlbum([FromBody] List<AlbumVM> albumVMs)
        {
            if (albumVMs==null)
            {
                ViewBag.Message = "Ürün bulunamadı.";
            }
            return PartialView("_SingleAlbum", albumVMs);
        }
        [HttpPost]
        public IActionResult SingleAlbumArea([FromBody] List<AlbumVM> albumVMs)
        {
            if (albumVMs == null)
            {
                ViewBag.Message = "Ürün bulunamadı.";
            }
            return PartialView("_SingleAlbumArea", albumVMs);
        }
    }
}
