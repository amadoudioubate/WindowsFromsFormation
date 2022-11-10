using _06_DAO.DAO;
using _06_DAO.Model;
using System.Configuration;

namespace _06_DAO
{
    public partial class Form1 : Form
    {
        private readonly IContactDAO _dao;
        public Form1()
        {
            
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            _dao = new ContactDAO(ConfigurationManager.ConnectionStrings["chConnexion"].ConnectionString);
            //_dao.AddContact(new Contact("Duck", "Fifi", "fifi@gmail.com", "12452563"));

            BindDataGrid();
        }

        private void BindDataGrid()
        {
            dataGridContact.DataSource = _dao.GetAll();
            dataGridContact.Columns["id"].Visible = false;
            dataGridContact.ReadOnly = true;

            dataGridContact.Columns["Nom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridContact.Columns["Prenom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridContact.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridContact.Columns["Telephone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridContact.Columns["Nom"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridContact.Columns["Prenom"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridContact.Columns["Email"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridContact.Columns["Telephone"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridContact.Columns["Nom"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridContact.Columns["Prenom"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridContact.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridContact.Columns["Telephone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridContact.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnValide_Click(object sender, EventArgs e)
        {
            _dao.AddContact(new Contact(textNom.Text, textPrenom.Text, textEmail.Text, textTel.Text));

            BindDataGrid();
        }
    }
}