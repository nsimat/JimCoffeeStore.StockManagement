using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JimCoffeeStore.StockManagement.Models
{
    public class Coffee
    {
        public int CoffeId { get; set; }
        public string CoffeeName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Country OriginCountry { get; set; }
        public bool InStock { get; set; }
        public int AmountInStock { get; set; }
        public DateTime FirstAddedToStockDate { get; set; }
        public int ImageId { get; set; }
    }
}
