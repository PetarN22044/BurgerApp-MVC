using BurgerApp.Data.Repository;
using BurgerApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Data.DataRepositories
{
    // na ist nacin kako predhodnata domasna skoro identicno ja imam istata logika i kaj order i kaj burger so to so imame nasleduvanje od  IBurgerRepository
    // pa posle si gi redime vo konstruktor so private readonly i taaka natamu
    public class BurgerRepository : IBurgerRepository
    {
        private readonly  List<Burger> burgers;

        public BurgerRepository()
        {
            burgers = new List<Burger>();
        }
        public void AddBurger(Burger burger)
        {
            burgers.Add(burger);    
        }

        public void DeleteBurger(int id)
        {
            var burgerToDelete = GetBurgerById(id);
            if (burgerToDelete != null)
            {
                burgers.Remove(burgerToDelete);

            };
        }

        public IEnumerable<Burger> GetAllBurgers()
        {
            return burgers;
        }

        public Burger GetBurgerById(int id)
        {
            return burgers.FirstOrDefault(x => x.Id == id);

        }

        public void UpdateBurger(Burger burger)
        {
            var existingBurgerOne = GetBurgerById(burger.Id);
            if (existingBurgerOne != null)
            {
                existingBurgerOne.Name = burger.Name;
                existingBurgerOne.Price = burger.Price;
                existingBurgerOne.IsVegetarian = burger.IsVegetarian;
                existingBurgerOne.IsVegan = burger.IsVegan;
                existingBurgerOne.HasFries = burger.HasFries;
            }
        }
    }
}
