using System;
using System.Collections.Generic;
using System.Text;
using TheNightingalesSing.Model.Entities;

namespace TheNightingalesSing.BLL.Abstract
{
    public interface IUserBLL :IBaseBLL<User>
    {
        public User GetUserByActCode(Guid code);
        public void InsertUser(User entity, string Password);
        public User GetUserByLoginData(string userName, string password);
    }
}
