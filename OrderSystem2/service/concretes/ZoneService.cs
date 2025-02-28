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
    public class ZoneService : IZoneService
    {
        private readonly IZoneRepository zoneRepository;

        public ZoneService(IZoneRepository zoneRepository)
        {
            this.zoneRepository = zoneRepository;
        }

        public void Add(Zone entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Zone> GetAll()
        {
           return zoneRepository.GetAll();
        }

        public Zone GetById(int id)
        {
            throw new NotImplementedException();
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
