using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace autoRepairShop.Product
{
    public partial class ProductPage : Page
    {
        private static ProductPage page = new ProductPage();
        public ProductPage()
        {
            InitializeComponent();
            dataGrid.ItemsSource = DataBaseEntities.GetEntities().product.ToList();
        }
        public static ProductPage GetPage() => page;

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.frameManager.Navigate(new EditPage((sender as Button).DataContext as product));
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.frameManager.Navigate(new AddPage(null));
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
              var productRemove = dataGrid.SelectedItems.Cast<product>().ToList();
              if (MessageBox.Show($"Удалить следующие {productRemove.Count()} " +
                  $"Товары?", "Внимание",
                  MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
              {
                  try
                  {
                      DataBaseEntities.GetEntities().product.RemoveRange(productRemove);
                      DataBaseEntities.GetEntities().SaveChanges();
                      MessageBox.Show("Товары удалены");
                      dataGrid.ItemsSource = DataBaseEntities.GetEntities().product.ToList();
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show(ex.Message.ToString());
                  }
             }
        }

        private void btnRef_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = DataBaseEntities.GetEntities().product.ToList();
        }
        private void btnReno_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = DataBaseEntities.GetEntities().product.Where(x => x.brand == "Renault").ToList();

        }

        private void btnLada_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = DataBaseEntities.GetEntities().product.Where(x => x.brand == "Lada").ToList();

        }
        private void btntoyota_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = DataBaseEntities.GetEntities().product.Where(x => x.brand == "Toyota").ToList();
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            dataGrid.ItemsSource = DataBaseEntities.GetEntities().product.
                Where(x => x.nameProd == search.Text || x.nameProd.Contains(search.Text)).
                ToList(); 
        }
    }
}
