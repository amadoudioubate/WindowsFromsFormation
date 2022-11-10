using MultiWindows;

namespace _06_MultiWindows
{
    public partial class Form1 : Form
    {
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
            FormProduits formProd = new(); // Cr�er une instance de form produits qu'on a cr�e

            formProd.ShowDialog(); // ShowDialog : ouverture en mode modal

        }
    }
}