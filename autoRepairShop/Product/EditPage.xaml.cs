using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public partial class EditPage : Page
    {             
            private product editItem = new product();
            public EditPage(product selectedProduct)
            {
                InitializeComponent();
            if (selectedProduct != null)
                editItem = selectedProduct;
            DataContext = editItem;
            nameProdTxt.Text.Trim();
            }
        


            private void btnExit_Click(object sender, RoutedEventArgs e)
            {
                Manager.frameManager.Navigate(ProductPage.GetPage());
            }

            private void btnApply_Click(object sender, RoutedEventArgs e)
            {
                if (nameProdTxt.Text == string.Empty ||
                    brandTxt.Text == string.Empty ||
                    costTxt.Text == string.Empty
                    )
                {
                    MessageBox.Show("заполните поля");
                    return;
                }
                else
                {
                    
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
