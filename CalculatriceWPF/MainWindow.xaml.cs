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

namespace CalculatriceWPF
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

        private void Key_Click(object sender, RoutedEventArgs e)
        {
            if (sender is not Button button) return; // Verifie que mon object sender est bien un button sinon on continue pas (return)

            string? key = button.Content.ToString(); // On ne sait jamais ce que l'utilisateur peut essayer de mettre donc string? au lieu de string

            if (String.IsNullOrEmpty(key)) return; // On peut aussi lever des Exception surtout dans la vraie vie au lieu de return

            int currentPos = txt_Operation.SelectionStart; // Recupère la position du curseur

            switch (key)
            {
                case "DEL": // Enlever un seul caractère à la position du curseur

                    if(currentPos > 0)
                    {
                        txt_Operation.Text = txt_Operation.Text.Remove(currentPos - 1, 1);
                        txt_Operation.SelectionStart = currentPos - 1;
                    }
                    break;
                case "C":
                    txt_Operation.Clear();
                    txt_Result.Text = String.Empty;
                    break;
                case "=":

                    Calcul c = new(txt_Operation.Text);

                    txt_Result.Text = c.GetResult().ToString();

                    break;
                default: // Les autres boutons qui servent à afficher
                    txt_Operation.Text = txt_Operation.Text.Trim().Insert(currentPos, key);
                    txt_Operation.SelectionStart = currentPos + 1; // decalle la position du curseur
                    break;
            }
        }
    }
}
