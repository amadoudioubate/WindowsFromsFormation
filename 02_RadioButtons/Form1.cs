namespace _02_RadioButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textSolde.Enabled = false;
            textSolde.Text = "0";
            radioDepot.Checked = true;
        }

        private void buttonValide_Click(object sender, EventArgs e)
        {
            //double solde = Double.Parse(textSolde.Text.Replace('.', ','));

            if (!Double.TryParse(textSolde.Text.Replace('.', ','), out double solde))
            {
                MessageBox.Show($"Solde {textSolde.Text} invalide", "Solde", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Double.TryParse(textMontant.Text.Replace('.', ','), out double montant) || montant <= 0)
            {
                MessageBox.Show($"Montant {textMontant.Text} invalide", "Solde", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioDepot.Checked)
            {
                solde += montant;
                textSolde.Text = solde.ToString();
            }
            else
            {
                if (solde < montant)
                {
                    MessageBox.Show($"Solde insuffisant : {solde} < {montant}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                solde -= montant;
                textSolde.Text = solde.ToString();
            }
        }
    }
}