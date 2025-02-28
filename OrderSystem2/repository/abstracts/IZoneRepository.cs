using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem2.model;

namespace OrderSystem2.repository.abstracts
{
    public interface IZoneRepository : IGenericRepository<Zone>
    {
        public List<Zone> GetZoneByFactory(int id);

        public string GetZoneNameByFarmerId(int id);
    }
}
