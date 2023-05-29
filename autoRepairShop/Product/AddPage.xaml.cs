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

namespace autoRepairShop.Product
{

    public partial class AddPage : Page
    {
        private static AddPage page = new AddPage();
        //private product addItem = new product();
        public AddPage()
        {
            InitializeComponent();
            //brandCombo.ItemsSource = DataBaseEntities.GetEntities().brand.ToList();
            //DataContext = addItem;
        }
        public static AddPage GetPage() => page;

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Manager.frameManager.Navigate(ProductPage.GetPage());
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            if (nameProdTxt.Text == string.Empty ||
             brandCombo.SelectedItem == null ||
             costTxt.Text == string.Empty ||
             quantityTxt.Text == string.Empty
             )
            {
                MessageBox.Show("заполните поля");
                return;
            }
            /*else
            {
                editItem.brandID = DataBaseEntities.GetEntities().brand.ToList().
                FirstOrDefault(x => x.brand == brandCombo.Text).id;
                DataBaseEntities.GetEntities().products.Add(addItem);
                try
                {
                    DataBaseEntities.GetEntities().SaveChanges();
                    Manager.frameManager.Navigate(ProductPage.GetPage());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }*/
        }
    }
}
