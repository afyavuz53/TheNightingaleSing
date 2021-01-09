using System;
using System.Collections.Generic;
using System.Text;
using TheNightingalesSing.Core.Entity;

namespace TheNightingalesSing.BLL.Abstract
{
    public interface IBaseBLL<TEntity>
        where TEntity : BaseEntity
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void DeleteByID(int id);
        TEntity Get(int id);
        ICollection<TEntity> GetAll();
    }
}
