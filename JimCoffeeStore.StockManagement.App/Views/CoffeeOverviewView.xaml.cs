using JimCoffeeStore.StockManagement.App.Extensions;
using JimCoffeeStore.StockManagement.App.Services;
using JimCoffeeStore.StockManagement.DAL;
using JimCoffeeStore.StockManagement.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<Coffee> coffees;

        public CoffeeOverviewView()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            CoffeeRepository coffeeRepository = new CoffeeRepository();
            CoffeeDataService coffeeDataService = new CoffeeDataService(coffeeRepository);
            coffees = coffeeDataService.GetAllCoffees().ToObservableCollection();
            CoffeeListView.ItemsSource = coffees;
        }

        private void CoffeeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedCoffee = e.AddedItems[0] as Coffee;

            if(e != null)
            {
                CoffeeIdLabel.Content = selectedCoffee.CoffeeId;
                CoffeeNameLabel.Content = selectedCoffee.CoffeeName;
                DescriptionLabel.Content = selectedCoffee.Description;
                PriceLabel.Content = selectedCoffee.Price.ToString("c");
                StockAmountLabel.Content = selectedCoffee.AmountInStock.ToString();
                FirstTimeAddedLabel.Content = selectedCoffee.FirstAddedToStockDate.ToShortDateString();

                BitmapImage img = new BitmapImage();
                img.BeginInit();
                img.UriSource = new Uri("/JimCoffeeStore.StockManagement.App;component/Images/coffee" + selectedCoffee.CoffeeId + ".jpg", UriKind.Relative);
                img.EndInit();
                CoffeeImage.Source = img;
            }
        }

        private void EditCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            CoffeeDetailView coffeeDetailView = new CoffeeDetailView();
            coffeeDetailView.SelectedCoffee = selectedCoffee;

            var window = Window.GetWindow(this);
            window.Content = coffeeDetailView;            
        }

        private void AddFakeCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            Coffee coffee = new Coffee()
            {
                CoffeeId = 123,
                CoffeeName = "Test coffee",
                Description = "Simply the best coffee",
                ImageId = 1,
                AmountInStock = 1000,
                InStock = true,
                FirstAddedToStockDate = new DateTime(2014, 1, 3),
                OriginCountry = Country.Brasil,
                Price = 15
            };
            coffees.Add(coffee);
        }
    }
}
