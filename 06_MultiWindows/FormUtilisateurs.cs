using _07_MultiWindows.Services;
using MultiWindows.DAO;
using MultiWindows.Model;
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
    public partial class FormUtilisateurs : Form
    {
        readonly IUtilisateurService _service;
        public FormUtilisateurs(string cstring)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            foreach (Profile p in Enum.GetValues(typeof(Profile)))
            {
                comboboxProfile.Items.Add(p);
            }

            _service = new UtilisateurService(new UtilisateurDAO(cstring));

        }

        private void FormUtilisateurs_Load(object sender, EventArgs e)
        {
            BindDatagrid();
        }

        private void BindDatagrid()
        {
            dataGridUtilisateurs.DataSource = _service.GetAll();

            dataGridUtilisateurs.Columns["login"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridUtilisateurs.Columns["password"].Visible = false;
            //dataGridUtilisateur.Columns["password"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridUtilisateurs.Columns["photo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridUtilisateurs.Columns["profile"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridUtilisateurs.Columns["login"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridUtilisateur.Columns["password"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridUtilisateurs.Columns["photo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridUtilisateurs.Columns["profile"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridUtilisateurs.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridUtilisateurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridUtilisateurs.ReadOnly = true;
            dataGridUtilisateurs.ClearSelection();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (_service.GetByLogin(textLogin.Text) is not null)
            {
                MessageBox.Show("Ce login n'est plus disponible", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Utilisateur u = new(textLogin.Text, textPassword.Text, pictureAvatar.ImageLocation, (Profile)comboboxProfile.SelectedIndex);

            string? newLogin = _service.Insert(u);

            if (!String.IsNullOrEmpty(newLogin))
            {
                MessageBox.Show($"Utilisateur {newLogin} créé avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Impossible de créer l'utilisateur", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindDatagrid();
        }
    }
}
