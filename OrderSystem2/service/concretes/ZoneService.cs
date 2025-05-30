
using OrderSystem2.entity;
using OrderSystem2.repository.abstracts;
using OrderSystem2.service.abstracts;

namespace OrderSystem2.service.concretes
{
    public class ZoneService : IZoneService
    {
        private readonly IZoneRepository zoneRepository;

        public ZoneService(IZoneRepository zoneRepository)
        {
            this.zoneRepository = zoneRepository;
        }

        public void Add(Zone entity)
        {
            zoneRepository.Add(entity);
        }

        public void Delete(int id)
        {
            zoneRepository.Delete(id);
        }

        public List<Zone> GetAll()
        {
           return zoneRepository.GetAll();
        }

        public Zone GetById(int id)
        {
           return zoneRepository.GetById(id);
        }

        public List<Zone> GetZoneByFactoryId(int id)
        {
            return zoneRepository.GetZoneByFactory(id);
        }

        public string GetZoneNameByFarmerId(int id)
        {
            return zoneRepository.GetZoneNameByFarmerId(id);
        }

        public void Update(Zone entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
