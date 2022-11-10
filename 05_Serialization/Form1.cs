using _05_Serializable_dll;

namespace _05_Serialization
{
    public partial class Form1 : Form
    {
        List<CompteBancaire> comptes;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            comptes = new();
            btnSupprimer.Visible = false; // Rendre invisible btnSupprimer au chargement
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Ajouter la dll en tant que dépendance de build ET sur (certains visual studio....)
            // Ajouter au projet en choisant d'impoter dll
            CompteBancaire cb = new(textNumero.Text, Convert.ToDouble(textSolde.Text));

            lstAccounts.Items.Add(cb.ToString());
            comptes.Add(cb);

            Clear();
        }

        private void Clear()
        {
            textSolde.Text = String.Empty;
            textNumero.Text = String.Empty;

            lstAccounts.SelectedItem = null;

            btnAjouter.Text = "Ajouter";
        }

        private void lstAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstAccounts.SelectedItem is not null)
            {
                btnSupprimer.Visible = true;
                btnEffacer.Visible = true;
                btnAjouter.Text = "Modifier";

                // Récuperer le compte bancaire à partir de lstAccounts
                CompteBancaire currentCompte = comptes[lstAccounts.SelectedIndex];

                textNumero.Text = currentCompte.Numero.ToString();
                textSolde.Text = currentCompte.Solde.ToString();
            }
            else
            {
                btnSupprimer.Visible = false;
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // verifie que j'ai un élément selectionné
            if (lstAccounts.SelectedItem is not null)
            {
                if (MessageBox.Show("Etes vous sur de vouloir supprimer le compte?",
                    "Suppression de compte",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    comptes.RemoveAt(lstAccounts.SelectedIndex);
                    lstAccounts.Items.Remove(lstAccounts.SelectedItem);

                    Clear();
                }
            }
        }

        private void btnSauvegarderBin_Click(object sender, EventArgs e)
        {
            Save(".bin");
        }

        private void btnSauvegarderXML_Click(object sender, EventArgs e)
        {
            Save(".xml");
        }

        private void btnSauvegarderJSON_Click(object sender, EventArgs e)
        {
            Save(".json");
        }

        private void btnSauvegarderCSV_Click(object sender, EventArgs e)
        {
            Save(".csv");
        }

        private void Save(string fileType)
        {
            saveFileDialog1.InitialDirectory = @"C:\Users\Admin Stagiaire\Desktop\Exports";

            saveFileDialog1.FileName = $"exports{fileType}";
            saveFileDialog1.Filter = $"Files|*{fileType}";
            saveFileDialog1.Title = $"Save {fileType}";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;

                switch (fileType)
                {
                    case "bin":
                        Serialize.ExportBin(path,comptes);
                        break;
                    case "xml":
                        Serialize.ExportXML(path, comptes);
                        break;
                    case "json":
                        Serialize.ExportJSON(path, comptes);
                        break;
                    case "csv":
                        Serialize.ExportCSV(path, comptes);
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnRestaurerBin_Click(object sender, EventArgs e)
        {
            Restaure(".bin"); 
        }

        private void btnRestaurerXML_Click(object sender, EventArgs e)
        {
            Restaure(".xml");
        }

        private void btnRestaurerJSON_Click(object sender, EventArgs e)
        {
            Restaure(".json");
        }

        private void btnRestaurerCSV_Click(object sender, EventArgs e)
        {
            Restaure(".csv");
        }

        private void Restaure(string fileType)
        {
            saveFileDialog1.InitialDirectory = @"C:\Users\Admin Stagiaire\Desktop\Exports";

            saveFileDialog1.FileName = $"impors{fileType}";
            saveFileDialog1.Filter = $"Files|*{fileType}";
            saveFileDialog1.Title = $"Restaure {fileType}";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;

                switch (fileType)
                {
                    case "bin":
                        Serialize.ImportBin(path);
                        break;
                    case "xml":
                        Serialize.ImportXML(path);
                        break;
                    case "json":
                        Serialize.ImportJSON(path);
                        break;
                    case "csv":
                        Serialize.ImportCSV(path);
                        break;
                    default:
                        break;
                }

                lstAccounts.Items.Clear();

                foreach (CompteBancaire cb in comptes)
                {
                    lstAccounts.Items.Add(cb);
                }

            }

        }
    }
}