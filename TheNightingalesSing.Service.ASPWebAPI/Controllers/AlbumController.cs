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
    public class AlbumController : ControllerBase
    {
        IAlbumBLL albumBLL;
        public AlbumController(IAlbumBLL bLL)
        {
            albumBLL = bLL;
        }
        List<AlbumDto> ConvertAlbumDto(List<Album> albums)
        {
            List<AlbumDto> albumDtos = new List<AlbumDto>();
            foreach (Album item in albums)
            {
                albumDtos.Add(new AlbumDto
                {
                    AlbumID = item.ID,
                    ArtUrl = item.ArtUrl,
                    Price = item.Price,
                    Title = item.Title,
                    ArtistName = item.Artist.FullName,
                    GenreName = item.Genre.Name
                });
            }
            return albumDtos;
        }
        List<AlbumGenreDto> ConvertAlbumGenreDto(List<Album> albums)
        {
            List<AlbumGenreDto> albumDtos = new List<AlbumGenreDto>();
            foreach (Album item in albums)
            {
                albumDtos.Add(new AlbumGenreDto
                {
                    AlbumID = item.ID,
                    ArtUrl = item.ArtUrl,
                    Title = item.Title,
                    GenreName = item.Genre.Name
                });
            }
            return albumDtos;
        }
        [HttpGet]
        public IActionResult GetAlbums()
        {
            List<AlbumDto> albums = ConvertAlbumDto(albumBLL.GetAll().ToList());
            return Ok(albums);
        }
        [HttpGet]
        public IActionResult GetLastest()
        {
            List<AlbumDto> albums = ConvertAlbumDto(albumBLL.GetLastestAlbums().ToList());
            return Ok(albums);
        }
        public IActionResult GetDisplayAlbum()
        {
            List<AlbumDto> albums = ConvertAlbumDto(albumBLL.GetDisplayAlbum().ToList());
            return Ok(albums);
        }
        [HttpGet("{id}")]
        public IActionResult GetByLetter(char id)
        {
            List<Album> albums = albumBLL.GetByLetter(id).ToList();
            if (albums == null)
            {
                return Ok();
            }
            return Ok(ConvertAlbumGenreDto(albums));
        }

        [HttpGet]
        public IActionResult GetStartWithNumber()
        {
            List<AlbumGenreDto> albums = ConvertAlbumGenreDto(albumBLL.GetStartWithNumber().ToList());
            return Ok(albums);
        }
        [HttpGet]
        public IActionResult GetAlbumsGenre()
        {
            List<AlbumGenreDto> albums = ConvertAlbumGenreDto(albumBLL.GetAll().ToList());
            return Ok(albums);
        }
        [HttpGet("{id}")]
        public IActionResult GetAlbumById(int id)
        {
            Album incomingAlbum = albumBLL.Get(id);
            AlbumDto album = new AlbumDto()
            {
                AlbumID = incomingAlbum.ID,
                Title = incomingAlbum.Title,
                ArtUrl = incomingAlbum.ArtUrl,
                Price = incomingAlbum.Price,
                ArtistName = incomingAlbum.Artist.FullName,
                GenreName = incomingAlbum.Genre.Name
            };
            return Ok(album);
        }
        List<AlbumTableDto> ConvertAlbumTable(List<Album> albums)
        {
            List<AlbumTableDto> albumTableDtos = new List<AlbumTableDto>();
            foreach (Album item in albums)
            {
                AlbumTableDto tableDto = new AlbumTableDto()
                {
                    AlbumID = item.ID,
                    Title = item.Title,
                    Stock = item.Stock,
                    Price = item.Price,
                    Continued = item.Continued,
                    Discount = item.Discount,
                    ArtistName = item.Artist.FullName,
                    GenreName = item.Genre.Name,
                    IsActive = item.IsActive
                };
                albumTableDtos.Add(tableDto);
            }
            return albumTableDtos;
        }
        public IActionResult GetAlbumForAdmin()
        {
            List<AlbumTableDto> tableDtos = ConvertAlbumTable(albumBLL.GetAll().ToList());
            return Ok(tableDtos);
        }
        [HttpGet("{word}")]
        public IActionResult GetAlbumByConstainForAdmin(string word)
        {
            List<AlbumTableDto> tableDtos = ConvertAlbumTable(albumBLL.GetAlbumByConstain(word).ToList());
            return Ok(tableDtos);
        }
        Album ConvertAlbum(AlbumInsDto dto)
        {
            Album album = new Album()
            {
                ID = dto.AlbumID,
                Title = dto.Title,
                ArtUrl = dto.ArtUrl,
                Price = dto.Price,
                ArtistID = dto.ArtistID,
                GenreID = dto.GenreID,
                Stock = dto.Stock
            };
            return album;
        }
        //[HttpPost]
        //public IActionResult InsertAlbum(AlbumInsDto dto)
        //{
        //    try
        //    {
        //        albumBLL.Insert(ConvertAlbum(dto));
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        public IActionResult InsertAlbum(Album dto)
        {
            try
            {
                albumBLL.Insert(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetAlbumByIdForAdmin(int id)
        {
            Album incomingAlbum = albumBLL.Get(id);
            AlbumInsDto album = new AlbumInsDto()
            {
                AlbumID = incomingAlbum.ID,
                Title = incomingAlbum.Title,
                ArtUrl = incomingAlbum.ArtUrl,
                Price = incomingAlbum.Price,
                Stock = incomingAlbum.Stock,
                ArtistID = incomingAlbum.ArtistID,
                GenreID = incomingAlbum.GenreID
            };
            return Ok(album);
        }
        public IActionResult UpdateForAdmin(Album dto)
        {
            try
            {
                albumBLL.Update(dto);
                return Ok();
            }
            catch (Exception )
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public IActionResult DeleteByID(int id)
        {
            albumBLL.DeleteByID(id);
            return Ok();
        }
        //post yokmuş :D  hemen yapalım

        [HttpPost]
        public IActionResult AlbumPost(AlbumDto dto)
        {
            return Ok();
        }
    }
}
