using System;
using System.Collections.Generic;
using System.Text;
using TheNightingalesSing.BLL.Abstract;
using TheNightingalesSing.DAL.Abstract;
using TheNightingalesSing.Model.Entities;

namespace TheNightingalesSing.BLL.Concrete
{
    class ArtistService : IArtistBLL
    {
        IArtistDAL artistDAL;
        public ArtistService(IArtistDAL dAL)
        {
            artistDAL = dAL;
        }
        void CheckArtist(Artist artist)
        {
            if (string.IsNullOrEmpty(artist.FullName) || string.IsNullOrEmpty(artist.Bio)||string.IsNullOrWhiteSpace(artist.FullName)||string.IsNullOrWhiteSpace(artist.Bio))
            {
                throw new Exception("Artist adı ve açıklaması boş bırakılamaz.");
            }
        }
        public void Insert(Artist entity)
        {
            CheckArtist(entity);
            artistDAL.Add(entity);
        }

        public void Update(Artist entity)
        {
            CheckArtist(entity);
            artistDAL.Update(entity);
        }
        public void Delete(Artist entity)
        {
            entity.IsActive = false;
            artistDAL.Update(entity);
        }

        public void DeleteByID(int id)
        {
            Artist silinecek = Get(id);
            silinecek.IsActive = false;
            artistDAL.Update(silinecek);
        }

        public Artist Get(int id)
        {
            return artistDAL.Get(a => a.ID == id && a.IsActive, a => a.Album);
        }

        public ICollection<Artist> GetAll()
        {
            return artistDAL.GetAll(a=>a.IsActive);
        }
    }
}
