using JimCoffeeStore.StockManagement.App.Services;
using JimCoffeeStore.StockManagement.DAL;
using JimCoffeeStore.StockManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JimCoffeeStore.StockManagement.App.Views
{
    /// <summary>
    /// Logique d'interaction pour CoffeeOverviewView.xaml
    /// </summary>
    public partial class CoffeeOverviewView : UserControl
    {
        private Coffee selectedCoffee;

        public CoffeeOverviewView()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            CoffeeRepository coffeeRepository = new CoffeeRepository();
            CoffeeDataService coffeeDataService = new CoffeeDataService(coffeeRepository);
            CoffeeListView.ItemsSource = coffeeDataService.GetAllCoffees();
        }

        private void CoffeeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void EditCoffeeButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
