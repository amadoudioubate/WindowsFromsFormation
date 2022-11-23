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

namespace NavigationMultiWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); // bug si on reconnait plus InitializeComponent();=> propriété du projet => decoche et coche activez WPF pour ce projet
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Menu 'New' Clicked !");
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Menu 'Open' Clicked !");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Menu 'Exit' Clicked !");
        }
    }
}
