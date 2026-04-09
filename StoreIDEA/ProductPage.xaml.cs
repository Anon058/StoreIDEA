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
        private readonly Users _user;
        public ProductPage(Users user)
        {
            InitializeComponent();
            LoadData();
            _user = user;

            if(user == null)
            {
                return;
            }
            if(user.RoleID == 1)
            {
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
       
        private void LoadData()
        {
            if(EditPage.count == 0)
            {
                productListView.Items.Clear();
            }

            productListView.ItemsSource = db.Products.ToList();
        }
        private void Name2Click(object sender, RoutedEventArgs e)
        {

        }
        private void HistoryClick(object sender, RoutedEventArgs e)
        {
            
        }


        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = productListView.SelectedItem as Products;

            if(selectedItem == null)
            {
                StaticObjects.desktopFrame.Navigate(new EditPage(null, () => LoadData()));
                return;
            }

            Products selectedProduct = db.Products.FirstOrDefault(x => x.ProductID == selectedItem.ProductID);

            EditPage content = new EditPage(selectedProduct, () => LoadData());
            StaticObjects.desktopFrame.Navigate(content);
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
