using OrderApp.Entities.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Entities.Entity
{
    public class Order : EntityBase
    {
        public Order()
        {
            OrderDetail = new List<OrderDetail>();
        }
        public string OrderNumber { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual IEnumerable<OrderDetail> OrderDetail { get; set; }
    }
}
