using MultiWindows.Model;
using MultiWindows.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiWindows
{
    public partial class FormProduitAjouter : Form
    {
        IProduitService _produitService;

        Produit Produit; // objet de type produit

        public FormProduitAjouter(IProduitService service, Produit? produit = null)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            textId.Enabled = false;

            _produitService = service;

            if (produit is null)
            {
                Produit = new();
                textId.Text = "0";
            }
            else
            {
                Produit = produit;

                textId.Text = Produit.Id.ToString();

                textDescription.Text = Produit.Description;

                textPrix.Text = Produit.Prix.ToString();

                textQuantite.Text = Produit.Quantite.ToString();

                btnAjouter.Text = "Modifier";
            }
           
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (textId.Text != String.Empty)
                {
                    Produit.Id = Convert.ToInt32(textId.Text);
                }


                Produit.Description = textDescription.Text;

                Produit.Prix = Convert.ToDouble(textPrix.Text);

                Produit.Quantite = Convert.ToInt32(textQuantite.Text);

                if (btnAjouter.Text == "Ajouter")
                {
                    _produitService.Add(Produit);
                }
                else
                {
                    _produitService.Update(Produit);
                }



                this.Close();

                // dataGrid de ma fenetre parente se met à jour

                if (this.Owner is FormProduits parent) // Si this.Owner est FormProduits parent
                {
                    // Il faut passer la propriété 'Modifiers' de 'dataGridProduits' de private à public
                    // pour pouvoir y accéder
                    parent.dataGridProduits.DataSource = _produitService.GetAll();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
