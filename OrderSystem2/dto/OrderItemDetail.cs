using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem2.dto
{
    public class OrderItemDetail
    {
        public string ProductName { get; set; }
        public float Quantity { get; set; }
        public string UnitName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price { get; set; }
        public decimal AreaSize { get; set; }
       
    }
}
