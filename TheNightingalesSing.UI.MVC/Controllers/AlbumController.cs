using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheNightingalesSing.UI.MVC.Models;

namespace TheNightingalesSing.UI.MVC.Controllers
{
    public class AlbumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SingleAlbum([FromBody] List<AlbumGenreVM> albumVMs)
        {
            if (albumVMs == null || albumVMs.Count == 0)
            {
                ViewBag.Message = "Ürün bulunamadı.";
            }
            return PartialView("_SingleAlbumItem", albumVMs);
        }
    }
}
