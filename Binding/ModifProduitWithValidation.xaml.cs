using Binding.DAO;
using Binding.Models;
using System.Windows;
using System.Windows.Input;

namespace Binding
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand Update = new(
            "Update",
            "Update", typeof(CustomCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.S, ModifierKeys.Control)
            });
    }
    /// <summary>
    /// Logique d'interaction pour ModifProduitWithValidation.xaml
    /// </summary>
    public partial class ModifProduitWithValidation : Window
    {
        private readonly IProduitDAO _dao;

        //public Produit Product { get; set; } // Remplacé par proprerty Binding



        public Produit Product
        {
            get { return (Produit)GetValue(ProductProperty); }
            set { SetValue(ProductProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Product.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProductProperty =
            DependencyProperty.Register("Product", typeof(Produit), typeof(ModifProduitWithValidation), new PropertyMetadata(new Produit()));


        public ModifProduitWithValidation(IProduitDAO dao, Produit p)
        {
            InitializeComponent();

            _dao = dao;

            Product = p;

            // On va pas le faire comme ça on va Remplacé cette méthode pas BINDING
            /*
            TxtBoxId.Text = Product.Id.ToString();
            TxtBoxDescription.Text = Product.Description;
            TxtBoxPrix.Text = Product.Prix.ToString();
            */
        }

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.SizeToContent = SizeToContent.WidthAndHeight;
        }

        private void Update_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (TxtBoxDescription_Error.Text.Length > 0 || TxtBoxPrix_Error.Text.Length >0)
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
            
        }


        // Remplacer par la commande Update_Executed "Update"
        /*private void BtnSauvegarder_Click(object sender, RoutedEventArgs e)
        {
            _dao.Update(Product);

            this.Close();
        }*/
        private void Update_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _dao.Update(Product);

            this.Close();
        }
    }
}

