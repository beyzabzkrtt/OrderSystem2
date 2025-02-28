﻿using OrderSystem2.model;

namespace OrderSystem2.service.abstracts
{
    public interface IZoneService : IGenericService<Zone>
    {
        public List<Zone> GetZoneByFactoryId(int id);
        public string GetZoneNameByFarmerId(int id);
    }
}
