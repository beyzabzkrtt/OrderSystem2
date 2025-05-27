using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem2.repository.concretes;

namespace OrderSystem2.service.concretes
{
    public class RoleService
    {
        private readonly RoleRepository repository;
        public RoleService(RoleRepository repository)
        {
            this.repository = repository;
        }

        public void AddRole(int zoneId, int roleTypeId)
        {
            repository.AddRole(zoneId, roleTypeId);
        }
    }
}
