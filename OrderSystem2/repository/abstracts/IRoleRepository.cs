
using OrderSystem2.entity;

namespace OrderSystem2.repository.abstracts
{
    public interface IRoleRepository : IGenericRepository<Role>
    {
        int AddRole(int zoneId, int roleTypeId);
    }
}
