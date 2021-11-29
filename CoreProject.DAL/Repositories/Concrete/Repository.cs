using CoreProject.DAL.Context;
using CoreProject.DAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreProject.DAL.Repositories.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DataContext _dataContext;
        protected readonly DbSet<T> _table;
        public Repository(DataContext dataContext)
        {
            _dataContext = dataContext;
            _table = _dataContext.Set<T>();
        }
        public void Add(T entity)
        {
            _table.Add(entity);
        }

        public void Delete(int id)
        {
            _table.Remove(GetById(id));
        }

        public List<T> GetAll()
        {
            return _table.ToList();
        }

        public T GetById(int id)
        {
            return _table.Find(id);
        }
    }
}
