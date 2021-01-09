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
    public class GenreController : ControllerBase
    {
        IGenreBLL genreBLL;
        public GenreController(IGenreBLL bLL)
        {
            genreBLL = bLL;
        }        
        public IActionResult Get()
        {
            List<GenreDto> genreDtos = new List<GenreDto>();
            List<Genre> genres = genreBLL.GetAll().ToList();
            foreach (Genre item in genres)
            {
                genreDtos.Add(new GenreDto() 
                { 
                    GenreID = item.ID, 
                    Name = item.Name 
                });
            }
            return Ok(genreDtos);
        }
    }
}
