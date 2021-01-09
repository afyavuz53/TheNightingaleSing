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
    public class AlbumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoadTable([FromBody]List<AlbumTableVM> tableVM)
        {
            if (tableVM == null || tableVM.Count == 0)
            {
                ViewBag.Message = "Ürün bulunamadı.";
            }
            return PartialView("_AlbumTableItem", tableVM);
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
