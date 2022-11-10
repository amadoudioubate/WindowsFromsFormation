namespace _03_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            textEcrire.Multiline = true;
            textLire.Multiline = true;
        }

        private void btnEcrire_Click(object sender, EventArgs e)
        {
            // .ShowDialog : ouvre en modal

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName; // On récupère le nom du fichier

                // Ecrire dans un fichier

                try
                {
                    Files.Write(path, textEcrire.Text, true);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fichier introuvable");
            }

        }

        private void btnLire_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName; // On ouvre le nom du fichier

                // Lire dans un fichier

                try
                {
                    textLire.Text  = Files.Reader(path);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fichier introuvable");
            }
        }
    }
}