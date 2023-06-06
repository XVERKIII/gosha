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
 
        private product addItem = new product();
        public AddPage(product selectedProduct)
        {
            InitializeComponent();          
            DataContext = addItem;
        }


        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Manager.frameManager.Navigate(ProductPage.GetPage());
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            if (nameProdTxt.Text == string.Empty ||
             brandTxt.Text == string.Empty ||
             costTxt.Text == string.Empty ||
             quantityTxt.Text == string.Empty
             )
            {
                MessageBox.Show("заполните поля");
                return;
            }
            else
            {
                
                DataBaseEntities.GetEntities().product.Add(addItem);
                try
                {
                    DataBaseEntities.GetEntities().SaveChanges();
                    Manager.frameManager.Navigate(ProductPage.GetPage());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
