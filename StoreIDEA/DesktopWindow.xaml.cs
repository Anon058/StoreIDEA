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

namespace StoreIDEA
{
    /// <summary>
    /// Логика взаимодействия для DesktopWindow.xaml
    /// </summary>
    public partial class DesktopWindow : Window
    {
        public DesktopWindow()
        {
            InitializeComponent();
            StaticObjects.desktopFrame = DesktopFrame;
            new MainWindow().ShowDialog();
        }
    }
}
