using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProject.DAL.Repositories.Interface
{
    public interface IRepository<T> where T:class
    {
        void Add(T entity);
        void Delete(int id);
        T GetById(int id);
        List<T> GetAll();

    }
}
