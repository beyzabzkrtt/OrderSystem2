﻿namespace OrderSystem2.entity
{
    public class Zone : BaseModel
    {
        public int FactoryId { get; set; }
        public string Name { get; set; }

        public List<Field?> Fields { get; set; }
        public List<Farmer?> Farmers { get; set; }
    }
}
