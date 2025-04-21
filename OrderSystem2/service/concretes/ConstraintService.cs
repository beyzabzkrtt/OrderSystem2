using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem2.entity;
using OrderSystem2.repository.abstracts;
using OrderSystem2.service.abstracts;

namespace OrderSystem2.service.concretes
{
    public class ConstraintService : IConstraintService
    {
        private readonly IConstraintRepository constraintRepository;

        public ConstraintService(IConstraintRepository constraintRepository)
        {
            this.constraintRepository = constraintRepository;
        }

        public void Add(Constraint entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Constraint> GetAll()
        {
           return constraintRepository.GetAll();
        }

        public Constraint GetById(int id)
        {
            return constraintRepository.GetById(id);
        }

        public List<Constraint> GetListById(int id)
        {
            return constraintRepository.GetListById(id);
        }

        public Constraint GetMaxByProductId(int id)
        {
            return constraintRepository.GetMaxByProductId(id);
        }

        public Constraint GetMinByProductId(int id)
        {
            return constraintRepository.GetMinByProductId(id);
        }

        public void Update(Constraint entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
