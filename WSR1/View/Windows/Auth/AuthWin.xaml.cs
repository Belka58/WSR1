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
using WSR1.AppDataFiles;
using WSR1.View.Windows.StartScreen;

namespace WSR1.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWin.xaml
    /// </summary>
    public partial class AuthWin : Window
    {
        public AuthWin()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            //При нажатии на кнопку btnEnter, происходит проверка логина и пароля, если всё подходит, открывается главное окно
            var users = ConnectOdb.wSR1.User.ToList();

            for (int i = 0; i < users.Count; i++)
            {
                if (tbLogin.Text == users[i].UserLogin && tbPass.Text == users[i].UserPassword)
                {
                    if (users[i].UserRole == 1)
                        Admin.isAdmin = true;

                    StartScreenWin startScreenWin = new StartScreenWin();
                    startScreenWin.Show();

                    this.Close();
                }

            }
 
        }
    }
}
