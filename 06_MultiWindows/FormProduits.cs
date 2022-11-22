using MultiWindows.DAO;
using MultiWindows.Services;

namespace MultiWindows
{
    public partial class FormProduits : Form
    {
        readonly IProduitService _service; // Au lancement de mon interface je veux charger IProduitService
        public FormProduits(string cstring)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            _service = new ProduitService(new ProduitDAO(cstring));

            btnSupprimer.Enabled = false;
        }

        private void FormProduits_Load(object sender, EventArgs e)
        {
            // Appeler le service 
            dataGridProduits.DataSource = _service.GetAll();
            // Debut pour rendre jolie DataGridProduits
            dataGridProduits.Columns["id"].Visible = false;

            dataGridProduits.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridProduits.Columns["Prix"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridProduits.Columns["Quantite"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridProduits.Columns["Description"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridProduits.Columns["Prix"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridProduits.Columns["Quantite"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridProduits.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridProduits.Columns["Prix"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridProduits.Columns["Quantite"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridProduits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProduits.ReadOnly = true;
            // Fin pour rendre jolie DataGridProduits
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
            if(btnAjouter.Text == "Ajouter")
            {
                FormProduitAjouter formProduitAjouter = new(_service);

                // this permet de déclarer l'objet courant (fenetre courante ici) courantpropriétaire 'formProduitAjouter'
                formProduitAjouter.ShowDialog(this);
            }
            else if(dataGridProduits.SelectedRows.Count != 0)
            {
                int id = (int)dataGridProduits.SelectedRows[0].Cells[0].Value;

                if(id != 0)
                {
                    FormProduitAjouter formProduitAjouter = new(_service, _service.GetById(id));
                    formProduitAjouter.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Aucun produit selectionné");
                }
            }

            dataGridProduits.ClearSelection();
            
        }

        // Evenement (changement d'état d'une ligne dataDridProduits) 
        private void dataGridProduits_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridProduits.SelectedRows.Count == 1)
            {
                btnAjouter.Text = "Modifier";
                btnSupprimer.Enabled = true;
            }
            else
            {
                btnAjouter.Text = "Ajouter";
                btnSupprimer.Enabled = false;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridProduits.SelectedRows[0].Cells[0].Value;

            if (id != 0)
            {
                _service.Delete(id);
                dataGridProduits.DataSource = _service.GetAll(); // Mettre à jour dataGridProduits
            }
            else
            {
                MessageBox.Show("Aucun produit selectionné");
            }

        }

        private void FormProduits_Click(object sender, EventArgs e)
        {
            dataGridProduits.ClearSelection();
        }

      

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            dataGridProduits.ClearSelection();
            
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {

            if(btnRechercher.Text == "Rechercher")
            {
                dataGridProduits.DataSource = _service.Filter(textRechercher.Text);
                btnRechercher.Text = "Effacer";
            }
            else
            {
                dataGridProduits.DataSource = _service.GetAll();
                btnRechercher.Text = "Rechercher";
                textRechercher.Text = String.Empty;
            }

            dataGridProduits.ClearSelection();

        }

        private void textRechercher_TextChanged(object sender, EventArgs e)
        {
            dataGridProduits.DataSource = _service.Filter(textRechercher.Text);
            dataGridProduits.ClearSelection();

            if(textRechercher.Text == String.Empty)
            {
                btnRechercher.Text = "Rechercher";
            }
            else
            {
                btnRechercher.Text = "Effacer";
            }
        }
    }
}
