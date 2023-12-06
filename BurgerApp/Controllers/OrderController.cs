using BurgerApp.Services.Interfaces;
using BurgerApp.Services.Models;
using BurgerApp.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            var orders = _orderService.GetAllOrders();
            return View(orders.ToList());
        }

        public IActionResult Details(int id)
        {
            var order = _orderService.GetOrderById(id);
            return View(order);
        }

        public IActionResult Create()
        {
            var orders = _orderService.GetAllOrders();
            ViewBag.Burgers = orders; // e ovoj e toj Bag koj so go zemam kako burgers posle vo vjuto
            return View();
        }

        [HttpPost]
        public IActionResult Create(OrderViewModel orderViewModel)
        {
            if (ModelState.IsValid)
            {
                _orderService.CreateOrder(orderViewModel);
                return RedirectToAction("Index", "Home");
            }

            var burgers = _orderService.GetAllOrders();
            ViewBag.Burgers = burgers;
            return View(orderViewModel);
        }

        public IActionResult Delete(int id)
        {
            var order = _orderService.GetOrderById(id);
            return View(order);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _orderService.DeleteOrder(id);
            return RedirectToAction("Index");
        }
    }
}
