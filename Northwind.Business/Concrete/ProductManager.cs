﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Concrete;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete
{
    public class ProductManager
    {
        ProductDal _productDal = new ProductDal();
        public List<Product> GetAll()
        {
            // Business codes 
            
            return _productDal.GetAll();
        }
    }
}