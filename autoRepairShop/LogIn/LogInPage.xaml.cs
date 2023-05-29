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

namespace autoRepairShop.LogIn
{
    /// <summary>
    /// Логика взаимодействия для LogInPage.xaml
    /// </summary>
    public partial class LogInPage : Page
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.frameManager.Navigate(Product.ProductPage.GetPage());

            /*  if (LogInBox.Text == string.Empty)
              {
                  MessageBox.Show("Введите логин и пароль");
              }
              else if (DataBaseEntities.GetEntities().logIn.Any(x => x.logIn == LogInBox.Text))
              {
                  Manager.frameManager.Navigate(Product.ProductPage.GetPage());
              }
              else
                MessageBox.Show("Неверный пароль!"); */
        }
    }
}
