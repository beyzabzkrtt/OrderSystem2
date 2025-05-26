

using OrderSystem2.entity;

namespace OrderSystem2.repository.abstracts
{
    public interface IZoneRepository : IGenericRepository<Zone>
    {
        public List<Zone> GetZoneByFactory(int id);

        public string GetZoneNameByFarmerId(int id);
    }
}
