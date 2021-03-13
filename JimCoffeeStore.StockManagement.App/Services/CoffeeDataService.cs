using JimCoffeeStore.StockManagement.DAL;
using JimCoffeeStore.StockManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JimCoffeeStore.StockManagement.App.Services
{
    public class CoffeeDataService : ICoffeeeDataService
    {
        private ICoffeeRepository coffeeRepository;

        public CoffeeDataService(CoffeeRepository repository)
        {
            coffeeRepository = repository;
        }

        public void DeleteCoffee(Coffee coffee)
        {
            coffeeRepository.DeleteCoffee(coffee);
        }

        public List<Coffee> GetAllCoffees()
        {
            return coffeeRepository.GetCoffees();
        }

        public Coffee GetCoffeeDetail(int coffeeId)
        {
            return coffeeRepository.GetCoffeeById(coffeeId);
        }

        public void UpdateCoffee(Coffee coffee)
        {
            coffeeRepository.UpdateCoffee(coffee);
        }
    }
}
