﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JimCoffeeStore.StockManagement.Model
{
    public class Coffee : INotifyPropertyChanged
    {
        private int coffeeId;
        private string coffeeName;
        private decimal price;
        //private string description;

        public int CoffeeId 
        {
            get 
            {
                return coffeeId;
            } 
            set
            {
                coffeeId = value;
                RaisePropertyChanged("CoffeeId");
            }
        }

        public string CoffeeName 
        { 
            get
            {
                return coffeeName;
            } 
            set
            {
                coffeeName = value;
                RaisePropertyChanged("CoffeeName");
            }
        }

        public decimal Price 
        { 
            get
            {
                return price;
            }
            set
            {
                price = value;
                RaisePropertyChanged("Price");
            }
        }

        public string Description { get; set; }
        public Country OriginCountry { get; set; }
        public bool InStock { get; set; }
        public int AmountInStock { get; set; }
        public DateTime FirstAddedToStockDate { get; set; }
        public int ImageId { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
