using CoreProject.DAL.Context;
using CoreProject.DAL.Repositories.Concrete;
using CoreProject.DAL.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProject.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;
        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        private ICategoryRepository _categoryRepository;
        public ICategoryRepository CategoryRepository 
        { 
            get
            {
                if (_categoryRepository==null)
                {
                    _categoryRepository = new CategoryRepository(_dataContext);
                }
                return _categoryRepository;
            }
        }
        private IProductRepository _productRepository;
        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository==null)
                {
                    _productRepository = new ProductRepository(_dataContext);
                }
                return _productRepository;
            }
        }

        public int Complete()
        {
            return _dataContext.SaveChanges();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
