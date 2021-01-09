using System;
using System.Collections.Generic;
using System.Text;
using TheNightingalesSing.Model.Entities;

namespace TheNightingalesSing.BLL.Abstract
{
    public interface IAlbumBLL:IBaseBLL<Album>
    {
        public ICollection<Album> GetLastestAlbums();
        public ICollection<Album> GetDisplayAlbum();
        public ICollection<Album> GetByLetter(char letter);
        public ICollection<Album> GetStartWithNumber();
        public ICollection<Album> GetAlbumByConstain(string word);
    }
}
