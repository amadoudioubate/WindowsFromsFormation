using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

/*
 * Quand on veut réaliser une opération qui prend du temps (attendre une connexion, chercher dans le système de fichier
 * 
 * l'UI va rester non responsive pendant toute la durée de l'opération
 *
 * Pour résoudre ce pb, plusieurs solutions dont la classe 'BackgroundWorker'
 * 
 * Disponible dans le namespace "System.ComponentModel"
 */
namespace BagroundWoker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly BackgroundWorker bgWorker = new();

        private readonly int counterMax = 50;
        public MainWindow()
        {
            InitializeComponent();

            progressBar.Maximum = counterMax;

            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.ProgressChanged += BgWorker_ProgressChanged;
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;


            // definir les propriétés de bgWorker
            bgWorker.WorkerReportsProgress = true; 
            bgWorker.WorkerSupportsCancellation = true;
        }

        private void BgWorker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblStartus.Content = "Cancelled!";
            }
            else
            {
                lblStartus.Content = "Completed!";
            }

            btnStart.Content = "Start";
        }

        private void BgWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            lblCount.Content = e.ProgressPercentage;
            progressBar.Value = e.ProgressPercentage; // Mettre à jour progressBar
        }

        
        private void BgWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= counterMax; i++)
            {
                bgWorker.ReportProgress(i);
                Thread.Sleep(100); // Pour que ça ne va pas trop vite
                
                if (bgWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
            }
        }

        private void btnStartClick(object sender, RoutedEventArgs e)
        {
            if (!bgWorker.IsBusy)
            {
                bgWorker.RunWorkerAsync();
                btnStart.Content = "Stop";
                lblStartus.Content = "Running...";
            }
            else
            {
                bgWorker.CancelAsync();
                btnStart.Content = "Start";
                lblStartus.Content = "Stopped...";
            }
        }
    }
}
