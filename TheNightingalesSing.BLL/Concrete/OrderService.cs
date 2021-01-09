using System;
using System.Collections.Generic;
using System.Text;
using TheNightingalesSing.BLL.Abstract;
using TheNightingalesSing.DAL.Abstract;
using TheNightingalesSing.Model.Entities;

namespace TheNightingalesSing.BLL.Concrete
{
    class OrderService : IOrderBLL
    {
        IOrderDAL orderDAL;
        public OrderService(IOrderDAL dAL)
        {
            orderDAL = dAL;
        }
        void CheckOrder(Order order)
        {
            if (order.OrderDate < DateTime.Now)
            {
                throw new Exception("Sipariş Tarihi bugününden tarihinden sonra olmalıdır.");
            }
        }
        public void Insert(Order entity)
        {
            CheckOrder(entity);
            orderDAL.Add(entity);
        }

        public void Update(Order entity)
        {
            CheckOrder(entity);
            orderDAL.Update(entity);
        }
        public void Delete(Order entity)
        {
            entity.IsActive = false;
            orderDAL.Update(entity);
        }

        public void DeleteByID(int id)
        {
            Order silinecek = Get(id);
            silinecek.IsActive = false;
            orderDAL.Update(silinecek);
        }

        public Order Get(int id)
        {
            return orderDAL.Get(o => o.ID == id);
        }

        public ICollection<Order> GetAll()
        {
            return orderDAL.GetAll();
        }        
    }
}
