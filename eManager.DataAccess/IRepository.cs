using System;
using System.Collections.Generic;
using System.Text;

namespace eManager.DataAccess
{
    public interface IRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        int Insert(T entity);
        int Update(T entity);
        void DeleteById(int id);
    }
}
