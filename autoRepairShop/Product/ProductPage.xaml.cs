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
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
       /* public class TypeIDConverter : IValueConverter
        {
            public object Convert(object value, Type targetType,
                object parameter, CultureInfo culture)
            {
                return DataBaseEntities.GetEntities().
                    typeOfProduct.ToList().FirstOrDefault(x => x.id == (int)value).typeProduct;
            }

            public object ConvertBack(object value, Type targetType,
                object parameter, CultureInfo culture)
            {
                return DependencyProperty.UnsetValue;
            }
        }*/
        private static ProductPage page = new ProductPage();
        public ProductPage()
        {
            InitializeComponent();
            //dataGrid.ItemsSource = DataBaseEntities.GetEntities().products;
        }
        public static ProductPage GetPage() => page;

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.frameManager.Navigate(AddPage.GetPage());
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            /*  var productRemove = dataGrid.SelectedItems.Cast<product>().ToList();
              if (MessageBox.Show($"Удалить следующие {productRemove.Count()} " +
                  $"поставки?", "Внимание",
                  MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
              {
                  try
                  {
                      DataBaseEntities.GetEntities().product.RemoveRange(productRemove);
                      DataBaseEntities.GetEntities().SaveChanges();
                      MessageBox.Show("Поставки удалены");
                      dataGrid.ItemsSource = DataBaseEntities.GetEntities().product;
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show(ex.Message.ToString());
                  }
             }*/
        }

        private void btnRef_Click(object sender, RoutedEventArgs e)
        {
           // dataGrid.ItemsSource = DataBaseEntities.GetEntities().product.ToList();
        }
        private void btnReno_Click(object sender, RoutedEventArgs e)
        {
            //dataGrid.ItemsSource = DataBaseEntities.GetEntities().product.Where(x => x.brandID == 1).ToList();

        }

        private void btnLada_Click(object sender, RoutedEventArgs e)
        {
            //dataGrid.ItemsSource = DataBaseEntities.GetEntities().product.Where(x => x.brandID == 2).ToList();

        }
        private void btntoyota_Click(object sender, RoutedEventArgs e)
        {
            //dataGrid.ItemsSource = DataBaseEntities.GetEntities().product.Where(x => x.brandID == 3).ToList();
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
           /* dataGrid.ItemsSource = DataBaseEntities.GetEntities().product.
                Where(x => x.nameProd == search.Text || x.nameProd.Contains(search.Text)).
                ToList(); */
        }
    }
}
