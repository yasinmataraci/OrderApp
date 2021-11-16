using OrderApp.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Business.Services.OrderServices
{
    public interface IOrderService
    {
        Order Add(Order entity);
        Order GetById(int id);
        List<Order> GetAll();
        Order Find(Expression<Func<Order, bool>> match);
    }
}
