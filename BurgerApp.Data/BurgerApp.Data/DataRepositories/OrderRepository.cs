using BurgerApp.Data.Repository;
using BurgerApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Data.DataRepositories
{
    // istovo i ovde e sea poso imame repositori sea ni trebit i nareden cekor Servisi
    public class OrderRepository : IOrderRepository
    {
        private List<Order> _orders;    

        public OrderRepository()
        {
            _orders = new List<Order>();    
        }
        public void AddOrder(Order order)
        {
            _orders.Add(order); 
        }

        public void DeleteOrder(int id)
        {
            var orderToDelete  = GetOrderById(id);  
            if (orderToDelete != null)
            {
                _orders.Remove(orderToDelete);
            }
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orders; 
        }

        public Order GetOrderById(int id)
        {
            return _orders.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateOrder(Order order)
        {
            var existingOrder = GetOrderById(order.Id);
            if (existingOrder != null)
            {
                existingOrder.FullName = order.FullName;
                existingOrder.Address = order.Address;
                existingOrder.IsDelivered = order.IsDelivered;
                existingOrder.Burger = order.Burger;
                existingOrder.Location = order.Location;
            }
        }
    }
}
