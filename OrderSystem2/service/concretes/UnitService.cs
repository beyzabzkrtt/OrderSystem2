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
    public class UnitService : IUnitService
    {
        private readonly IUnitRepository unitRepository;

        public UnitService(IUnitRepository unitRepository)
        {
            this.unitRepository = unitRepository;
        }

        public void Add(Unit entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Unit> GetAll()
        {
           return unitRepository.GetAll();
        }

        public Unit GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Unit entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
