using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZenTool.Domain.Entity;

namespace ZenTool.Domain.IRepository
{
    public interface IRepositoryBase<T> where T:EntityBase
    {
        long Add(T entity);

        void Delete(long id);

        void Update(T entity);

        T Get(long id);

        IQueryable<T> GetList();
    }
}
