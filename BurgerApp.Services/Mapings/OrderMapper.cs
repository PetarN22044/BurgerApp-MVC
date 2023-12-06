using BurgerApp.Domain;
using BurgerApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Mappers
{
    public static class OrderMapper
    {
        public static Order MapToOrder(OrderViewModel orderViewModel)
        {
            return new Order
            {
                Id = orderViewModel.Id,
                FullName = orderViewModel.FullName,
                Address = orderViewModel.Address,
                IsDelivered = orderViewModel.IsDelivered,
                Burger = BurgerMapper.MapToBurger(orderViewModel.Burger),
                Location = orderViewModel.Location
            };
        }

        public static OrderViewModel MapToOrderViewModel(Order order)
        {
            return new OrderViewModel
            {
             Id = order.Id,
             FullName = order.FullName,
             Address = order.Address,
             IsDelivered = order.IsDelivered,
             Burger = BurgerMapper.MapToBurgerViewModel(order.Burger),
             Location = order.Location
            };
        }
    }// istovo go pram i ovde ova inace go vidov ko sofiticirano neso barem za mene nekako gledase da ne pram eden maper ts 2,potocno koga imame 
    // prenos na info megu aplikacijava 
}