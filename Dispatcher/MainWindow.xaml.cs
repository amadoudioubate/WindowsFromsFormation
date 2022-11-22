using System;
using System.Collections.Generic;
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

namespace Dispatcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Thread? BgThead = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, RoutedEventArgs e)
        {
            //if(sender is not Button btn) return;
            //ExecuteCounter(); Pa responsive

            BgThead = new Thread(() => { ExecuteCounter(); });
            BgThead.Start();
        }

        public void ExecuteCounter()
        {
            try
            {
                Dispatcher.Invoke(() => { btnStart.Content = "Counting..."; btnStart.IsEnabled=false; });


                for (int i = 0; i <= 50; i++)
                {
                    //txtMessage.Text = i.ToString(); System.InvalidOperationException : 'Le thread appelant ne peut pas accéder à cet objet parce qu'un autre thread en est propriétaire.'
                    Dispatcher.Invoke(() => { txtMessage.Text = i.ToString(); });
                    Thread.Sleep(100);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
