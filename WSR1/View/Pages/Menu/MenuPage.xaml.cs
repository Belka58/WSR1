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
using WSR1.AppDataFiles;
using WSR1.View.CheckProduct;
using WSR1.View.EditProduct;

namespace WSR1.View.Pages.Menu
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
            CheckAdmin();
        }

        private void btnEditListProduct_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditProductPage());
        }

        private void btnCheckListProduct_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CheckProductPage());
        }

        private void CheckAdmin()
        {
            //Если пользователь авторизовался не как админ, то кнопка редактирования товаров не видна

            if (!Admin.isAdmin)
                btnEditListProduct.Visibility = Visibility.Hidden;

        }
    }
}
