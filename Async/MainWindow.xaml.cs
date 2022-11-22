using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Async
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static List<string> Sites
        {
            get
            {
                List<string> liste = new()
                {
                    "https://www.cnn.com",
                    "https://www.google.com",
                    "https://www.codeproject.com",
                    "https://www.dawan.fr",
                    "https://www.jehann.fr/",
                    "https://fr.wikipedia.org/wiki/Microsoft_.NET",
                    "https://www.twitter.com",
                    "https://www.facebook.com",
                    "https://www.amazon.com"
                };

                return liste;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        #region SYNCHRONE

        private void ExecuteSync_CLICK(object sender, RoutedEventArgs e)
        {
            var chrono = Stopwatch.StartNew();

            DownloadSync();

            chrono.Stop();

            Results.Content += $"Durée d'exécution totale : {chrono.ElapsedMilliseconds}";
        }

        private void DownloadSync()
        {
            Results.Content = String.Empty;

            foreach (var site in Sites) // Boucler sur notre liste de sites
            {
                WebSite downloaded = WebSite.Download(site);

                Results.Content += downloaded.ToString();    
            }
        }


        #endregion

        #region ASYNCHRONE
        private void ExecuteAsync_CLICK(object sender, RoutedEventArgs e)
        {
            var chrono = Stopwatch.StartNew();

            DownloadASync();

            chrono.Stop();

            Results.Content += $"Durée d'exécution totale : {chrono.ElapsedMilliseconds}";
        }

        private async Task DownloadASync()
        {
            Results.Content = String.Empty;

            foreach (var site in Sites) // Boucler sur notre liste de sites
            {

                // On part du principe qu'on ne peut pas rendre WebSite.Download directement asynchrone
                WebSite downloaded = await Task.Run(() =>WebSite.Download(site)); 

                Results.Content += downloaded.ToString();
            }
        }

        #endregion


        #region PARALLELE
        private void ExecuteParallelAsync_CLICK(object sender, RoutedEventArgs e)
        {

        }

        #endregion
    }
}
