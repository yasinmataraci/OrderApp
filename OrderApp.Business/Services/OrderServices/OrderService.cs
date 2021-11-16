using OrderApp.DAL.Abstract;
using OrderApp.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Business.Services.OrderServices
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order Add(Order entity)
        {
            return _orderRepository.Add(entity);
        }

        public Order GetById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public List<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public Order Find(Expression<Func<Order, bool>> match)
        {
            return _orderRepository.Find(match);
        }
    }
}
