using CoreProject.DAL.Context;
using CoreProject.DAL.Repositories.Interface;
using CoreProject.Domain.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProject.DAL.Repositories.Concrete
{
    public class CategoryRepository:Repository<Category>,ICategoryRepository
    {
        public CategoryRepository(DataContext context):base(context)
        {

        }
    }
}
