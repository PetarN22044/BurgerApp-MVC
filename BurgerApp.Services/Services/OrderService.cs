using BurgerApp.Data.Repository;
using BurgerApp.Domain;
using BurgerApp.Services.Interfaces;
using BurgerApp.Services.Models;
using BurgerApp.Services.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BurgerApp.Services.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;// istoto e i ovde

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public void CreateOrder(OrderViewModel orderViewModel)
        {
            Order order = OrderMapper.MapToOrder(orderViewModel);
            _orderRepository.AddOrder(order);
        }

        public void DeleteOrder(int id)
        {
            _orderRepository.DeleteOrder(id);
        }

        public IEnumerable<OrderViewModel> GetAllOrders()
        {
            IEnumerable<Order> orders = _orderRepository.GetAllOrders();
            return orders.Select(OrderMapper.MapToOrderViewModel);
        }

        public OrderViewModel GetOrderById(int id)
        {
            Order order = _orderRepository.GetOrderById(id);
            return OrderMapper.MapToOrderViewModel(order);
        }

        public void UpdateOrder(OrderViewModel orderViewModel)
        {
            Order order = OrderMapper.MapToOrder(orderViewModel);
            _orderRepository.UpdateOrder(order);
        }
    }
}

