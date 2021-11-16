using FluentValidation;
using OrderApp.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Business.Validations
{
    public class OrderValidation : AbstractValidator<Order>
    {
        public OrderValidation()
        {
            //RuleFor(x => x.Id).GreaterThan(0).WithMessage("Sipariş id gerekli!");
            RuleFor(x => x.TotalPrice).GreaterThan(0).WithMessage("Topltam fiyat gerekli!");
            RuleFor(x => x.OrderNumber).NotEmpty().WithMessage("Sipariş numarası gerekli!");

            RuleForEach(x => x.OrderDetail).ChildRules(y =>
             {
                 //y.RuleFor(x => x.Id).GreaterThan(0).WithMessage("Sipariş detay id gerekli!");
                 y.RuleFor(x => x.OrderId).GreaterThan(0).WithMessage("Sipariş id gerekli!");
                 y.RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adı gerekli!");
                 y.RuleFor(x => x.Quantity).GreaterThan(0).WithMessage("Adet gerekli!");
                 y.RuleFor(x => x.UnitPrice).GreaterThan(0).WithMessage("Fiyat gerekli!");
             });
        }
    }
}
