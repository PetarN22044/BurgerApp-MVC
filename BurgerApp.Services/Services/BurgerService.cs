using BurgerApp.Data.Repository;
using BurgerApp.Domain;
using BurgerApp.Services.Models;
using BurgerApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BurgerApp.Services.Services
{
    public class BurgerService : IBurgerService
    {
        private readonly IBurgerRepository _burgerRepository;//vo burger service imame od repositorito zavisnost a so to sme postignale DI 

        // taka da go ostvarivme to so se barase vo zadacata da imat DI
        // so znacit IBurgerRepository mi e od repozitorivo, a davat zavisnost na BurgerService konstruktorov ,i pokraj to so imat private,... so znacit imame
        // enkapsulacija i toj del e vklucen
        public BurgerService(IBurgerRepository burgerRepository)
        {
            _burgerRepository = burgerRepository;
        }

        public void AddBurger(BurgerViewModel burgerViewModel)
        {
            var burger = new Burger
            {
                Name = burgerViewModel.Name,
                Price = burgerViewModel.Price,
                IsVegetarian = burgerViewModel.IsVegetarian,
                IsVegan = burgerViewModel.IsVegan,
                HasFries = burgerViewModel.HasFries
            };

            _burgerRepository.AddBurger(burger);
        }

        public void DeleteBurger(int id)
        {
            _burgerRepository.DeleteBurger(id);
        }

        public IEnumerable<BurgerViewModel> GetAllBurgers()
        {
            var burgers = _burgerRepository.GetAllBurgers();

            var burgerViewModels = burgers.Select(burger => new BurgerViewModel
            {
                Id = burger.Id,
                Name = burger.Name,
                Price = burger.Price,
                IsVegetarian = burger.IsVegetarian,
                IsVegan = burger.IsVegan,
                HasFries = burger.HasFries
            });

            return burgerViewModels;
        }

        public BurgerViewModel GetBurgerById(int id)
        {
            var burger = _burgerRepository.GetBurgerById(id);

            if (burger != null)
            {
                var burgerViewModel = new BurgerViewModel
                {
                    Id = burger.Id,
                    Name = burger.Name,
                    Price = burger.Price,
                    IsVegetarian = burger.IsVegetarian,
                    IsVegan = burger.IsVegan,
                    HasFries = burger.HasFries
                };

                return burgerViewModel;
            }

            return null;
        }

        public void UpdateBurger(BurgerViewModel burgerViewModel)
        {
            var existingBurger = _burgerRepository.GetBurgerById(burgerViewModel.Id);

            if (existingBurger != null)
            {
                existingBurger.Name = burgerViewModel.Name;
                existingBurger.Price = burgerViewModel.Price;
                existingBurger.IsVegetarian = burgerViewModel.IsVegetarian;
                existingBurger.IsVegan = burgerViewModel.IsVegan;
                existingBurger.HasFries = burgerViewModel.HasFries;

                _burgerRepository.UpdateBurger(existingBurger);
            }
        }
    }
}
