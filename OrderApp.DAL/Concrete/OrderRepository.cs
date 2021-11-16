using OrderApp.DAL.Abstract;
using OrderApp.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.DAL.Concrete
{
    public class OrderRepository : Repository<Order>,IOrderRepository
    {
        public OrderRepository(OrderDbContext context) :base(context)
        {

        }
        
    }
}
