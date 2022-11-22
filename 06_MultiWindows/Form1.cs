using MultiWindows;
using System.Configuration;

namespace _06_MultiWindows
{
    public partial class Form1 : Form
    {
        readonly string cstring = ConfigurationManager.ConnectionStrings["chConnexion"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void produitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduits formProd = new(cstring); // Créer une instance de form produits qu'on a crée

            formProd.ShowDialog(); // ShowDialog : ouverture en mode modal

        }

        private void utilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtilisateurs formUtilisateurs = new(cstring); // Créer une instance de form produits qu'on a crée

            formUtilisateurs.ShowDialog(); // ShowDialog : ouverture en mode modal
        }
    }
}