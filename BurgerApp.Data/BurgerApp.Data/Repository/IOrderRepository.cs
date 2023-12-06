using BurgerApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Data.Repository
{
   public interface IOrderRepository
    {
        Order GetOrderById(int id);
        IEnumerable<Order> GetAllOrders();// istoto e i ovde  e sea vo dataRepository ja imame logikava
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int id);
    }
}
