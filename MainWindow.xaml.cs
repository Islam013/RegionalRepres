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
using RegionalRepres.View;

namespace RegionalRepres
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtEmployee_Click(object sender, RoutedEventArgs e)
        {
            WindowEmployee windowEmployee = new WindowEmployee();
            windowEmployee.Show();
        }

        private void BtRegion_Click(object sender, RoutedEventArgs e)
        {
            WindowRegion windowRegion = new WindowRegion();
            windowRegion.Show();
        }

        private void BtTerritory_Click(object sender, RoutedEventArgs e)
        {
            WindowTerritory windowTerritory = new WindowTerritory();
            windowTerritory.Show();
        }

        private void BtEmployeeTerritory_Click(object sender, RoutedEventArgs e)
        {
            WindowEmployeeTerritory windowEmployeeTerritory = new WindowEmployeeTerritory();
            windowEmployeeTerritory.Show();
        }

    }
}
