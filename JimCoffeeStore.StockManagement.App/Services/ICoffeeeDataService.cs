using JimCoffeeStore.StockManagement.Model;
using System.Collections.Generic;


namespace JimCoffeeStore.StockManagement.App.Services
{
    public interface ICoffeeeDataService
    {
        void DeleteCoffee(Coffee coffee);
        List<Coffee> GetAllCoffees();
        Coffee GetCoffeeDetail(int coffeeId);
        void UpdateCoffee(Coffee coffee);
    }
}
