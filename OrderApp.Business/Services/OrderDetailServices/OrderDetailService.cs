using OrderApp.DAL.Abstract;
using OrderApp.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Business.Services.OrderDetailServices
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository _orderDetailRepository;
        public OrderDetailService(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }
        public OrderDetail Add(OrderDetail entity)
        {
            return _orderDetailRepository.Add(entity);
        }
        public OrderDetail GetById(int id)
        {
            return _orderDetailRepository.GetById(id);
        }

        public List<OrderDetail> GetAll()
        {
            return _orderDetailRepository.GetAll();
        }

        public OrderDetail Find(Expression<Func<OrderDetail, bool>> match)
        {
            return _orderDetailRepository.Find(match);
        }
    }
}
