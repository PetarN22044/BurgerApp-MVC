


using BurgerApp.Domain;
using BurgerApp.Services.Models;

namespace BurgerApp.Services.Mappers
{
    public static class BurgerMapper
    {
        // ovde imam nekakov maper ts dva ko ke se vidit e sea kako i so pram ovde
        // na prviot MapToBuger imam od modelov rabotive so mi trebet so posle ke se smesat seto ova vo Views
        public static Burger MapToBurger(BurgerViewModel burgerViewModel)
        {
            return new Burger
            {
             Id = burgerViewModel.Id,
             Name = burgerViewModel.Name,
             Price = burgerViewModel.Price,
              IsVegetarian = burgerViewModel.IsVegetarian,
             IsVegan = burgerViewModel.IsVegan,
             HasFries = burgerViewModel.HasFries
            };
        }
        // a ovde imam maper od BurgerViewModel so parametar od Burger klasava
 public static BurgerViewModel MapToBurgerViewModel(Burger burger)
        {
       return new BurgerViewModel
        {
         Id = burger.Id,
         Name = burger.Name,
        Price = burger.Price,
        IsVegetarian = burger.IsVegetarian,
        IsVegan = burger.IsVegan,
        HasFries = burger.HasFries
            };
        }
    }
}
