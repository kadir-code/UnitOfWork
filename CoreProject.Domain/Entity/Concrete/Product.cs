using CoreProject.Domain.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProject.Domain.Entity.Concrete
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
