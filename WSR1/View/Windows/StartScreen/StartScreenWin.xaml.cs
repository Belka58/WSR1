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
using System.Windows.Shapes;
using WSR1.View.Pages.FAQ;
using WSR1.View.Pages.Menu;

namespace WSR1.View.Windows.StartScreen
{
    /// <summary>
    /// Логика взаимодействия для StartScreenWin.xaml
    /// </summary>
    public partial class StartScreenWin : Window
    {
        public StartScreenWin()
        {
            InitializeComponent();
            frameStart.Navigate(new MenuPage());
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            frameStart.GoBack();
        }

        private void btnFAQ_Click(object sender, RoutedEventArgs e)
        {
            frameStart.Navigate(new FAQPage());
        }

        private void frameStart_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            //Задаю проверку, если открыта страница Меню, кнопка назад не видна, если открыта другая страница, кнопка видна

            if (frameStart.Content.GetType().Name == "MenuPage")
            {
                btnGoBack.Visibility = Visibility.Hidden;
            }
             
            else
            {
                btnGoBack.Visibility = Visibility.Visible;
            }
             
        }
    }
}
