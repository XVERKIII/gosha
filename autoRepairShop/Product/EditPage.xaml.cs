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
    public partial class EditPage : Page
    {
        private static EditPage page = new EditPage();
        public EditPage()
        {
            InitializeComponent();
            //comboBox.ItemsSource = DataBaseEntities.GetEntities().brand.ToList();
        }
        public static EditPage GetPage() => page;

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Manager.frameManager.Navigate(Product.ProductPage.GetPage());
        }

        /*  public EditPage(product item) : this()
      {
          editItem = item;
          DataContext = editItem;
          brandCombo.SelectedIndex = item.typeID - 1;

      }*/
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
