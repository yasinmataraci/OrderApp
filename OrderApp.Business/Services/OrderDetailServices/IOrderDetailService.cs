using OrderApp.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Business.Services.OrderDetailServices
{
    public interface IOrderDetailService
    {
        OrderDetail Add(OrderDetail entity);
        OrderDetail GetById(int id);
        List<OrderDetail> GetAll();
        OrderDetail Find(Expression<Func<OrderDetail, bool>> match);
    }
}
