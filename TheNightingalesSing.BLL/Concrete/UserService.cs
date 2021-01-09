using System;
using System.Collections.Generic;
using System.Text;
using TheNightingalesSing.BLL.Abstract;
using TheNightingalesSing.BLL.Helper;
using TheNightingalesSing.DAL.Abstract;
using TheNightingalesSing.Model.Entities;
using TheNightingalesSing.Model.Enums;

namespace TheNightingalesSing.BLL.Concrete
{
    class UserService : IUserBLL
    {
        IUserDAL userDAL;
        public UserService(IUserDAL user)
        {
            userDAL = user;
        }
        void CheckUser(User user)
        {
            if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.LastName) || user.PasswordHash == null || user.PasswordSalt == null)
            {
                throw new Exception("Deger boş geçilemez");
            }
        }
        public void Insert(User entity)
        {
            CheckUser(entity);            
            entity.ActivationCode = Guid.NewGuid();
            userDAL.Add(entity);
        }

        public void Update(User entity)
        {
            CheckUser(entity);            
            userDAL.Update(entity);
        }
        public void Delete(User entity)
        {
            entity.IsActive = false;
            userDAL.Update(entity);
        }

        public void DeleteByID(int id)
        {
            User silinecek = Get(id);
            silinecek.IsActive = false;
            userDAL.Update(silinecek);
        }

        public User Get(int id)
        {
            return userDAL.Get(u => u.ID == id);
        }

        public ICollection<User> GetAll()
        {
            return userDAL.GetAll();
        }
        public User GetUserByActCode(Guid code)
        {
            return userDAL.Get(u => u.ActivationCode == code);
        }
        public void InsertUser(User entity,string password)
        {
            byte[] _hash;
            byte[] _salt;
            PasswordHelper.CreatePasswordHash(password, out _hash, out _salt);
            entity.PasswordHash= _hash;
            entity.PasswordSalt = _salt;
            CheckUser(entity);
            entity.ActivationCode = Guid.NewGuid();
            userDAL.Add(entity);
        }
        public User GetUserByLoginData(string userName,string password)
        {
            User login = userDAL.Get(u => u.UserName == userName);
            if (login==null)
            {
                throw new Exception("Giriş bilgileriniz yanlış.");
            }
            bool result=PasswordHelper.VerifyPasswordHash(password, login.PasswordHash, login.PasswordSalt);
            if (result)
            {
                return login;
            }
            return null;
        }
    }
}
