using OrderApp.Entities.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Entities.Entity
{
    public class OrderDetail : EntityBase
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal CargoPrice { get; set; }
        public virtual Order Order { get; set; }
    }
}
