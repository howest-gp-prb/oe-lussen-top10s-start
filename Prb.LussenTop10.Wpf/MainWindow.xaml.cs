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

namespace Prb.LussenTop10.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        const int MaxItems = 10;
        string[] catNames;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            catNames = new string[6];
            CreateCategories();
        }
        private void CreateCategories()
        {
            catNames[0] = "Auteurs";
            catNames[1] = "Films";
            catNames[2] = "Restaurants";
            catNames[3] = "Games";
            catNames[4] = "TV-series";
            catNames[5] = "Steden";
        }

        private void cmbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
        }



        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
