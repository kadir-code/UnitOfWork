using CoreProject.DAL.Context;
using CoreProject.DAL.Repositories.Interface;
using CoreProject.Domain.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreProject.DAL.Repositories.Concrete
{
    class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context):base(context)
        {

        }
       
    }
}
