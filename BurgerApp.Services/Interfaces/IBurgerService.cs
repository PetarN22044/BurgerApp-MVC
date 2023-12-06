using BurgerApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Interfaces
{
    public interface IBurgerService
    {
        // ovde isto 
        void AddBurger(BurgerViewModel burgerViewModel);
        void DeleteBurger(int id);
        IEnumerable<BurgerViewModel> GetAllBurgers();
        BurgerViewModel GetBurgerById(int id);
        void UpdateBurger(BurgerViewModel burgerViewModel);
    }
}
