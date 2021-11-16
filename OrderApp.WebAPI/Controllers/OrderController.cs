using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderApp.Business.Services.OrderServices;
using OrderApp.Business.Validations;
using OrderApp.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet]
        [Route("GetById")]
        public Order GetById(int id)
        {
            return _orderService.GetById(id);
        }

        [HttpGet]
        [Route("GetAll")]
        public List<Order> GetAll()
        {
            return _orderService.GetAll();
        }

        [HttpGet]
        [Route("Find")]
        public Order Find(int id)
        {
            return _orderService.Find(x => x.Id == id);
        }
        
        [HttpPost]
        [Route("Add")]
        public Order Add(Order order)
        {
            return _orderService.Add(order);
        }


        [HttpPost]
        [Route("AddWithValidations")]
        public IActionResult AddWithValidations(Order order)
        {
            OrderValidation validation = new OrderValidation();
            ValidationResult result = validation.Validate(order);
            if (result.IsValid)
            {
                return Ok(_orderService.Add(order));
            }

            return BadRequest(result.Errors);
        }
    }
}
