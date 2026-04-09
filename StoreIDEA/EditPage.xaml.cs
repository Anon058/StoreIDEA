using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity.Migrations;
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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        private Products _product;
        DBEntities db = new DBEntities();
        public static int count = 0;
        private Action _saveCallback;
        public EditPage(Products product, Action saveCallback)
        {
            InitializeComponent();
            _saveCallback = saveCallback;
            UnitOfMeasurementCb.ItemsSource = db.UnitOfMeasurements.ToList();
            SupplierCb.ItemsSource = db.Suppliers.ToList();
            ManufacturerCb.ItemsSource = db.Manufacturers.ToList();
            CategoryCb.ItemsSource = db.Categories.ToList();

            if(product == null)
            {
                Title = "Добавление товара";
                EditBtn.Content = "Добавить товар";
                count = 0;
                _product = new Products();
            }
            else
            {
                Title = "Редактирование товара";
                EditBtn.Content = "Редактировать товар";
                _product = product;
                count = 1;
                LoadData();
            }
        }

        public void LoadData()
        {
            ArticulTb.Text = _product.Articul;
            ProductNameTb.Text = _product.ProductName;
            UnitOfMeasurementCb.SelectedValue = _product.UnitOfMeasurementID;
            PriceTb.Text = _product.Price.ToString();
            SupplierCb.SelectedValue = _product.SupplierID;
            ManufacturerCb.SelectedValue = _product.ManufacturerID;
            CategoryCb.SelectedValue = _product.CategoryID;
            DiscountTb.Text = _product.Discount.ToString();
            QuantityInStockTb.Text = _product.QuantityInStock.ToString();
            DescriptionTb.Text = _product.Description.ToString();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _product.Articul = ArticulTb.Text;
                _product.ProductName = ProductNameTb.Text;
                _product.UnitOfMeasurementID = (int)UnitOfMeasurementCb.SelectedValue;
                _product.Price = int.Parse(PriceTb.Text);
                _product.SupplierID = (int)SupplierCb.SelectedValue;
                _product.ManufacturerID = (int)ManufacturerCb.SelectedValue;
                _product.CategoryID = (int)CategoryCb.SelectedValue;
                _product.Discount = int.Parse(DiscountTb.Text);
                _product.Description = DescriptionTb.Text;

                // если 0, то добавление, а если 1, то редактирование
                if (count == 0)
                {
                    db.Products.Add(_product);
                }
                if (count == 1)
                {
                    var editProduct = db.Products.First(p => p.ProductID == _product.ProductID);

                    editProduct.Articul = _product.Articul;
                    editProduct.ProductName = _product.ProductName;
                    editProduct.UnitOfMeasurementID = _product.UnitOfMeasurementID;
                    editProduct.Price = _product.Price;
                    editProduct.SupplierID = _product.SupplierID;
                    editProduct.ManufacturerID = _product.ManufacturerID;
                    editProduct.CategoryID = _product.CategoryID;
                    editProduct.Discount = _product.Discount;
                    editProduct.Description = _product.Description;
                }
                MessageBox.Show("Данные сохранены");
                db.SaveChanges();

                StaticObjects.desktopFrame.GoBack();
                _saveCallback?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e) => StaticObjects.desktopFrame.GoBack();

        private void UnitOfMeasurementCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
