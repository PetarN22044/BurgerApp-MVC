using BurgerApp.Services.Interfaces;
using BurgerApp.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Controllers
{
    public class BurgerController : Controller
    {
        private readonly IBurgerService _burgerService;

        public BurgerController(IBurgerService burgerService)
        {
            _burgerService = burgerService;
        }

        public IActionResult Index()
        {
            var burgers = _burgerService.GetAllBurgers();
            return View(burgers);
        }

        public IActionResult Edit(int id)
        {
            var burger = _burgerService.GetBurgerById(id);
            return View(burger);
        }

        [HttpPost]
        public IActionResult Edit(BurgerViewModel burgerViewModel)
        {
            if (ModelState.IsValid)
            {
                _burgerService.UpdateBurger(burgerViewModel);
                return RedirectToAction("Index");
            }

            return View(burgerViewModel);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(BurgerViewModel burgerViewModel)
        {
            if (ModelState.IsValid)// ovde koristime namerno ModelState.IsValid i ne koristam null, tuku ModelState koj vraka Bool tru ili false, a ne prazno ili null
            {
                _burgerService.AddBurger(burgerViewModel);
                return RedirectToAction("Index");
            }

            return View(burgerViewModel);
        }

        public IActionResult Delete(int id)
        {
            var burger = _burgerService.GetBurgerById(id);
            return View(burger);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _burgerService.DeleteBurger(id);
            return RedirectToAction("Index");
        }
    }
}
