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

namespace UserControls
{
    /// <summary>
    /// Logique d'interaction pour MainWindowWithControl.xaml
    /// </summary>
    public partial class MainWindowWithControl : Window
    {
        public MainWindowWithControl()
        {
            InitializeComponent();
        }

        private void JoindreClickBasic(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Basic", "Basic", MessageBoxButton.OK);
        }

        private void JoindreClickPremium(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Premium", "Premium", MessageBoxButton.OK);
        }
    }
}
