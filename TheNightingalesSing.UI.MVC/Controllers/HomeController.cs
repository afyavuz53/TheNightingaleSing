using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheNightingalesSing.UI.MVC.Helper;
using TheNightingalesSing.UI.MVC.Models;

namespace TheNightingalesSing.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //List<AlbumVM> albumList = ApiJsonHelper<AlbumVM>.GetEntityList("album/getalbums");
            AlbumVM album = new AlbumVM()
            {
                AlbumID = 2,
                ArtistName = "aaa",
                ArtUrl = "ssss",
                GenreName = "sadsad",
                Price=123,
                Title="asd"
            };
            ApiJsonHelper<AlbumVM>.PostEntity("album/AlbumPost", album);
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
