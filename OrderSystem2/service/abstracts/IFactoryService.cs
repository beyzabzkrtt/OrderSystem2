﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem2.model;

namespace OrderSystem2.service.abstracts
{
    public interface IFactoryService : IGenericService<Factory>
    {
        public List<Category> GetCategories(int factoryId);
    }
}
