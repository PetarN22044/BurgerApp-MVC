using BurgerApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Data.Repository
{
  public interface IBurgerRepository 
    {
        Burger GetBurgerById(int id);
        IEnumerable<Burger> GetAllBurgers();// ovoj mi e genericki  IEnumerable i se koristit ako sakam  da koristam T generic i to vo burger i imam
        // skratena postapka nego da pram racno generik klasi

        // ovde imame samo prikaz
        void AddBurger(Burger burger);
        void UpdateBurger(Burger burger);
        void DeleteBurger(int id);
    }
}
// ovde prajme sea od burger repositori na nacin koj