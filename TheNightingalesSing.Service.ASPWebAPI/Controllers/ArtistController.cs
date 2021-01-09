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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        IArtistBLL artistBLL;
        public ArtistController(IArtistBLL bLL)
        {
            artistBLL = bLL;
        }
        List<ArtistDto> ConvertArtistsDto(List<Artist> artist)
        {
            List<ArtistDto> artistDtos = new List<ArtistDto>();
            foreach (Artist item in artist)
            {
                ArtistDto dto = new ArtistDto()
                {
                    ArtistID = item.ID,
                    FullName = item.FullName,
                    Bio = item.Bio
                };
                artistDtos.Add(dto);
            }
            return artistDtos;
        }
        public IActionResult GetArtistForAdmin()
        {
            List<ArtistDto> artists = ConvertArtistsDto(artistBLL.GetAll().ToList());
            return Ok(artists);
        }
        Artist ConvertArtist(ArtistDto dto)
        {
            Artist artist = new Artist()
            {
                ID = dto.ArtistID,
                FullName = dto.FullName,
                Bio = dto.Bio
            };
            return artist;
        }
        ArtistDto ConvertArtistDto(Artist item)
        {
            ArtistDto artistDto = new ArtistDto()
            {
                ArtistID = item.ID,
                FullName = item.FullName,
                Bio = item.Bio
            };
            return artistDto;
        }
        [HttpPost]
        public IActionResult InsertArtist(ArtistDto artist)
        {
            try
            {
                artistBLL.Insert(ConvertArtist(artist));
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        public IActionResult UpdateArtist(ArtistDto artist)
        {
            try
            {
                artistBLL.Update(ConvertArtist(artist));
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetArtistById(int id)
        {
            ArtistDto artist = ConvertArtistDto(artistBLL.Get(id));
            return Ok(artist);
        }
        [HttpGet("{id}")]
        public IActionResult DeleteByID(int id)
        {
            artistBLL.DeleteByID(id);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetForSelect()
        {
            List<ArtistDto> artistDtos = ConvertArtistsDto(artistBLL.GetAll().ToList());
            return Ok(artistDtos);            
        }
    }
}
