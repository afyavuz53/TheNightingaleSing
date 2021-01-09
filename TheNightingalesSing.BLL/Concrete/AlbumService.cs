using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheNightingalesSing.BLL.Abstract;
using TheNightingalesSing.DAL.Abstract;
using TheNightingalesSing.Model.Entities;

namespace TheNightingalesSing.BLL.Concrete
{
    class AlbumService : IAlbumBLL
    {
        IAlbumDAL albumDAL;
        public AlbumService(IAlbumDAL dal)
        {
            albumDAL = dal;
        }

        void CheckAlbum(Album album)
        {
            if (album.Title.Length <= 2)
            {
                throw new Exception("Albüm adının karakter sayısı 2'den büyük olmalıdır.");
            }
        }

        public void Insert(Album entity)
        {
            CheckAlbum(entity);
            albumDAL.Add(entity);
        }

        public void Update(Album entity)
        {
            CheckAlbum(entity);
            albumDAL.Update(entity);
        }
        public void Delete(Album entity)
        {
            entity.IsActive = false;
            albumDAL.Update(entity);
        }

        public void DeleteByID(int id)
        {
            Album silinecek = Get(id);
            silinecek.IsActive = false;
            albumDAL.Update(silinecek);
        }

        public Album Get(int id)
        {
            return albumDAL.Get(a => a.ID == id && a.IsActive && a.Continued, a => a.Artist, a => a.Genre);
        }

        public ICollection<Album> GetAll()
        {
            return albumDAL.GetAll(null, a => a.Artist, a => a.Genre);
        }
        public ICollection<Album> GetLastestAlbums()
        {
            return albumDAL.GetAll(a => a.Continued && a.IsActive, a => a.Artist, a => a.Genre).OrderByDescending(a=>a.CreateDate).Take(10).ToList();
        }
        public ICollection<Album> GetDisplayAlbum()
        {
            return albumDAL.GetAll(a => a.Continued && a.IsActive, a => a.Artist, a => a.Genre).Take(12).ToList();
        }
        public ICollection<Album> GetByLetter(char letter)
        {            
            return albumDAL.GetAll(a => a.Continued && a.IsActive,a=>a.Artist, a => a.Genre).Where(a => a.Title.ToUpper().StartsWith(letter)).ToList();
        }
        public ICollection<Album> GetStartWithNumber()
        {
            ICollection<Album> albums = new List<Album>();
            for (char i = '0'; i < '9'; i++)
            {
                List<Album> liste = albumDAL.GetAll(a => a.Continued && a.IsActive, a => a.Artist, a => a.Genre).Where(a => a.Title.ToUpper().StartsWith(i)).ToList();
                if (liste==null)
                {
                    continue;
                }
                foreach (Album item in liste)
                {
                    albums.Add(item);
                }
            }
             return albums;
        }
        public ICollection<Album> GetAlbumByConstain(string word)
        {
            string wordToLower = word.ToLower();
            return albumDAL.GetAll(null, a => a.Artist, a => a.Genre).Where(a => a.Title.ToLower().Contains(wordToLower)).ToList();
        }
    }
}
