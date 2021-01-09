using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheNightingalesSing.BLL.Abstract;
using TheNightingalesSing.Model.Entities;
using TheNightingalesSing.Service.ASPWebAPI.Models;

namespace TheNightingalesSing.Service.ASPWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        IAlbumBLL albumBLL;
        public CartController(IAlbumBLL bLL)
        {
            albumBLL = bLL;
        }
        [HttpGet("{id}")]
        public IActionResult GetCartItemById(int id)
        {
            Album album = albumBLL.Get(id);
            CartDto cartDto = new CartDto
            {
                ID = album.ID,
                Name = album.Title,
                Price = album.Price
            };
            return Ok(cartDto);
        }
    }
}
