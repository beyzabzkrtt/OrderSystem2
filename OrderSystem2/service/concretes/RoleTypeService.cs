using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem2.entity;
using OrderSystem2.repository.abstracts;

namespace OrderSystem2.service.concretes
{
    public class RoleTypeService
    {
        private readonly IRoleTypeRepository roleTypeRepository;

        public RoleTypeService(IRoleTypeRepository roleTypeRepository)
        {
            this.roleTypeRepository = roleTypeRepository;
        }

        public List<RoleType> GetAll()
        {
            return roleTypeRepository.GetAll();
        }

    }
}
