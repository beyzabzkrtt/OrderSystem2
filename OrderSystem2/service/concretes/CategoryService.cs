using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem2.model;
using OrderSystem2.repository.abstracts;
using OrderSystem2.service.abstracts;

namespace OrderSystem2.service.concretes
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
           return categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategoryByFactory(int id)
        {
            return categoryRepository.GetCategoryByFactory(id);
        }

        public List<Product> GetProducts(int id)
        {
           return categoryRepository.GetProducts(id);
        }

        public void Update(Category entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
