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
    /// Logique d'interaction pour CoffeeDetailView.xaml
    /// </summary>
    public partial class CoffeeDetailView : UserControl
    {
        public Coffee SelectedCoffee { get; set; }

        public CoffeeDetailView()
        {
            InitializeComponent();
            this.Loaded += CoffeeDetailView_Loaded;
        }

        private void CoffeeDetailView_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            CoffeeNameLabel.Content = SelectedCoffee.CoffeeName;
            CoffeeIdTextBox.Text = SelectedCoffee.CoffeeId.ToString();
            CoffeeDescriptionTextBox.Text = SelectedCoffee.Description;
            CoffeePriceTextBox.Text = SelectedCoffee.Price.ToString();
            StockAmountTextBox.Text = SelectedCoffee.AmountInStock.ToString();
            FirstTimeAddedTextBox.Text = SelectedCoffee.FirstAddedToStockDate.ToString();

            if (SelectedCoffee is SuperiorCoffee)
                ExtraDescriptionTextBox.Text = (SelectedCoffee as SuperiorCoffee).ExtraDescription;
            else
                ExtraDescriptionTextBox.Text = "NA";

            BitmapImage img = new BitmapImage();
            img.BeginInit();
            img.UriSource = new Uri("/JimCoffeeStore.StockManagement.App;component/Images/coffee" + SelectedCoffee.CoffeeId + ".jpg", UriKind.Relative);
            img.EndInit();
            CoffeeImage.Source = img;
        }

        private void SaveCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            window.Close();
        }

        private void DeleteCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            window.Close();
        }
    }
}
