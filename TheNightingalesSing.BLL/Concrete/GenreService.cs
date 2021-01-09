using System;
using System.Collections.Generic;
using System.Text;
using TheNightingalesSing.BLL.Abstract;
using TheNightingalesSing.DAL.Abstract;
using TheNightingalesSing.Model.Entities;

namespace TheNightingalesSing.BLL.Concrete
{
    class GenreService : IGenreBLL
    {
        IGenreDAL genreDAL;
        public GenreService(IGenreDAL dAL)
        {
            genreDAL = dAL;
        }
        void CheckGenre(Genre genre)
        {
            if (string.IsNullOrEmpty(genre.Name) && string.IsNullOrEmpty(genre.Description))
            {
                throw new Exception("Kategori adı ve açıklaması boş bırakılamaz.");
            }
        }
        public void Insert(Genre entity)
        {
            CheckGenre(entity);
            genreDAL.Add(entity);
        }

        public void Update(Genre entity)
        {
            CheckGenre(entity);
            genreDAL.Update(entity);
        }
        public void Delete(Genre entity)
        {
            entity.IsActive = false;
            genreDAL.Update(entity);
        }

        public void DeleteByID(int id)
        {
            Genre silinecek = Get(id);
            silinecek.IsActive = false;
            genreDAL.Update(silinecek);
        }

        public Genre Get(int id)
        {
            return genreDAL.Get(g => g.ID == id && g.IsActive, g => g.Album);
        }

        public ICollection<Genre> GetAll()
        {
            return genreDAL.GetAll();
        }
    }
}
