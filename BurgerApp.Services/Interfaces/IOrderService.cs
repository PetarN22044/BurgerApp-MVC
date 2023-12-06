using BurgerApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Interfaces
{
    public interface IOrderService
    {
        void CreateOrder(OrderViewModel orderViewModel);
        void DeleteOrder(int id);
        IEnumerable<OrderViewModel> GetAllOrders();
        OrderViewModel GetOrderById(int id);
        void UpdateOrder(OrderViewModel orderViewModel);
    }
}
