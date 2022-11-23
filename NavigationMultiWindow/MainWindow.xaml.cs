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

    public static class CustomCommands
    {
        // Exit premier param qui sera affiché
        // Exit 2eme Name me referencer
        // 3ème Classe qui propriétaire typeof(CustomCommands)
        // 4èeme param raccourci
        public static readonly RoutedUICommand Exit = new(
            "Exit",
            "Exit",
            typeof(CustomCommands),
            new InputGestureCollection() { new KeyGesture(Key.X, ModifierKeys.Control) }
            );

        // Rajouter ici d'autres Command personnalisées
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent(); // bug si on reconnait plus InitializeComponent();=> propriété du projet => decoche et coche activez WPF pour ce projet
            framePage.Content = new Page1(); // Au demarrage de mon appli on ouvre la Page1 par exemple (un choix)
        }

       
        private void Open_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Menu 'Open' Clicked !");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Fenetre ouverte en mode not modal, on aura accès à notre fenetre parente
        private void NotModal_Click(object sender, RoutedEventArgs e)
        {
            Child notModal = new() { Owner = this };
            notModal.Show();
        }

        // Fenetre ouverte en mode modal, on aura plus accès à notre fenetre parente
        private void Modal_Click(object sender, RoutedEventArgs e) 
        {
            Child notModal = new() { Owner = this };
            notModal.ShowDialog();
        }

        private void Page1_Click(object sender, RoutedEventArgs e)
        {
            framePage.Content = new Page1();
        }

        private void Page2_Click(object sender, RoutedEventArgs e)
        {
            framePage.Content = new Page2();
        }

        // Remplace
        //private void New_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Menu 'New' Clicked !");
        //}
        private void NewCommandExecute(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Menu 'New' Clicked  From Command with shortcut!");
        }

        private void NewCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ExitCommandExecute(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current?.Shutdown();
        }

        private void ExitCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
