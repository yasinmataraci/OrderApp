using OrderApp.DAL.Abstract;
using OrderApp.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.DAL.Concrete
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(OrderDbContext context) : base(context)
        {

        }

    }
}
