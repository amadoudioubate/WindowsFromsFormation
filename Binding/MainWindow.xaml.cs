using Binding.DAO;
using Binding.Models;
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

namespace Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        private readonly IProduitDAO _dao;
    
        public MainWindow()
        {
            InitializeComponent();

            _dao = new ProduitDAO();

            FillDataGrid();
        }

        private void FillDataGrid()
        {
            if(DGProduits.ItemsSource is null)
            {
                DGProduits.ItemsSource = _dao.GetAll();
            }
            else
            {
                DGProduits.Items.Refresh();
            }

            this.SizeToContent = SizeToContent.WidthAndHeight;
        }

        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {
            // On liste tour à tour les objets parents du bouton jusqu'à tomber sur un de type "DatagridRow"
            for (var obj = sender as Visual; obj != null; obj = VisualTreeHelper.GetParent(obj) as Visual)
            {
                if (obj is DataGridRow row)
                {
                    if (row.Item is Produit p)
                    {
                        // Créer une instance de ModifProduit puis l'ouvrir pas ShowDialog au click du bouton Modifier
                       /* var modal = new ModifProduit(_dao, p)
                        {
                            Owner = this
                        };*/

                        var modal = new ModifProduitWithValidation(_dao, p)
                        {
                            Owner = this
                        };

                        modal.ShowDialog();

                        break;
                        
                    }
                }
            }
        }

        private void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            // On liste tour à tour les objets parents du bouton jusqu'à tomber sur un de type "DatagridRow"
            for (var obj = sender as Visual; obj != null; obj = VisualTreeHelper.GetParent(obj) as Visual)
            {
                if(obj is DataGridRow row)
                {
                    if(row.Item is Produit p)
                    {
                        _dao.Delete(p.Id);
                        FillDataGrid();
                        break;
                    }
                }
            }
        }
    }
}
