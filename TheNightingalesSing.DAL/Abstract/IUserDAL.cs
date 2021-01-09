using System;
using System.Collections.Generic;
using System.Text;
using TheNightingalesSing.Core.DataAccess;
using TheNightingalesSing.Model.Entities;

namespace TheNightingalesSing.DAL.Abstract
{
    public interface IUserDAL :IRepository<User>
    {
    }
}
