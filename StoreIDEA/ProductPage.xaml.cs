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
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        DBEntities db = new DBEntities();
        public Products Product { get; }
        private readonly Users _user;
        public ProductPage(Users user)
        {
            InitializeComponent();
            productListView.ItemsSource = db.Products.ToList();
            _user = user;

            if(user == null)
            {
                return;
            }
            if(user.RoleID == 1)
            {
                AddBtn.Visibility = Visibility.Visible;
                EditBtn.Visibility = Visibility.Visible;
                RemoveBtn.Visibility = Visibility.Visible;
                CategoryCb.Visibility = Visibility.Visible;
                SupplierCb.Visibility = Visibility.Visible;
            }
            if(user.RoleID == 2)
            {
                CategoryCb.Visibility = Visibility.Visible;
                SupplierCb.Visibility = Visibility.Visible;
            }
        }
       
        private void Name2Click(object sender, RoutedEventArgs e)
        {

        }
        private void HistoryClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = productListView.SelectedItem as Products;

            Products selectedProduct = db.Products.FirstOrDefault(x => x.ProductID == selectedItem.ProductID);

            StaticObjects.desktopFrame.Navigate(new EditPage(selectedProduct));
        }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {

        }


        private void CategoryCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SupplierCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
