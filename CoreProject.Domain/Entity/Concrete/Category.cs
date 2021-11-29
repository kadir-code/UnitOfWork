using CoreProject.Domain.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProject.Domain.Entity.Concrete
{
    public class Category: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public List<Product> Products { get; set; }

    }
}
