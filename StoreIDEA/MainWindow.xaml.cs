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

namespace StoreIDEA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DBEntities db = new DBEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(loginTb.Text) || string.IsNullOrEmpty(passTb.Text))
            {
                MessageBox.Show("Вы не заполнили все поля", "Не критическая ошибка", MessageBoxButton.OK,MessageBoxImage.Warning);
                return;
            }
            Users user = db.Users.Where(u => u.Login == loginTb.Text).FirstOrDefault();

            if(user == null)
            {
                MessageBox.Show("Такого пользователя нет", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if(user.Password == passTb.Text)
            {
                ProductWindow product = new ProductWindow();

            }
        }
    }
}
