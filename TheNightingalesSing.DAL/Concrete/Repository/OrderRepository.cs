using System;
using System.Collections.Generic;
using System.Text;
using TheNightingalesSing.Core.DataAccess.EntityFramework;
using TheNightingalesSing.DAL.Abstract;
using TheNightingalesSing.Model.Entities;

namespace TheNightingalesSing.DAL.Concrete.Repository
{
    class OrderRepository: EFRepositoryBase<Order,TheNightingalesSingDbContext>,IOrderDAL
    {
    }
}
