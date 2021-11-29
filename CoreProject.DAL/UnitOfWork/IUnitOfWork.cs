using CoreProject.DAL.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProject.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository CategoryRepository { get; }
        IProductRepository ProductRepository { get; }
        int Complete();

    }
}
