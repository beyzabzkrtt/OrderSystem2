﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem2.model;

namespace OrderSystem2.service.abstracts
{
    public interface IProductService : IGenericService<Product>
    {
        public string GetFactoryName(int id);
        public string GetCategoryName(int id);
        public string GetUnitName(int id);
    }
}
