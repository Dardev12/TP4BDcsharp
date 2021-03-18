using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravailBDPart4
{
    public partial class AfficherCompeNageur : Form
    {
        public AfficherCompeNageur()
        {
            InitializeComponent();
        }

        public void Afficher()
        {
            using (var context = new bd_natationEntities())
            {
                dgvCompe.Columns[0].Name = "Id";
                dgvCompe.Columns[1].Name = "Nom";
                dgvCompe.Columns[2].Name = "Prenom";
                dgvCompe.Columns[3].Name = "Adresse Email";
                dgvCompe.Columns[4].Name = "ID Categorie";
                dgvCompe.DataSource = context.tbl_Nageur.ToList();
            }
                
        }

        private void AfficherCompeNageur_Load(object sender, EventArgs e)
        {
            dgvCompe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void AfficherCompe()
        {
            dgvCompe.Rows.Clear();

            using (var context = new bd_natationEntities())
            {
                List<tbl_Competition> list = new List<tbl_Competition>();

                list = context.tbl_Competition.SqlQuery("select tbl_Competition.Nom, tbl_Competition.Description " +
                    "from tbl_Nageur " +
                    "inner join tbl_Resultat on tbl_Nageur.ID = tbl_Resultat.Id_Nageur " +
                    "inner join tbl_Competition on tbl_Resultat.Id_competition = tbl_Competition.ID " +
                    "where tbl_Nageur.ID = @ID", new SqlParameter("ID", txtIdNageur.Text)).ToList();
                dgvCompe.DataSource = list;

                dgvCompe.Columns["tbl_Resultat"].Visible = false;
                dgvCompe.Columns["tbl_Categori_Compet"].Visible = false;

            }
        }

        private void dgvNageur_Click(object sender, EventArgs e)
        {
            txtIdNageur.Text = dgvNageur[0, dgvNageur.CurrentRow.Index].Value.ToString();
            txtNom.Text = dgvNageur[1, dgvNageur.CurrentRow.Index].Value.ToString();
            txtPrenom.Text = dgvNageur[2, dgvNageur.CurrentRow.Index].Value.ToString();
            
        }

        private void AfficherNageur()
        {
            dgvNageur.Rows.Clear();
            dgvNageur.ColumnCount = 3;
            dgvNageur.Columns[0].Name = "ID nageur";
            dgvNageur.Columns[1].Name = "Nom";
            dgvNageur.Columns[2].Name = "Prenom";

            using (var context = new bd_natationEntities())
            {
                List<tbl_Nageur> list = new List<tbl_Nageur>();
                list = context.tbl_Nageur.SqlQuery("SELECT * FROM tbl_Nageur WHERE nom = @nom", new SqlParameter("nom", txtSearchNageur.Text)).ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    dgvNageur.Rows.Add(list[i].ID, list[i].Nom, list[i].Prenom);
                }
            }
        }

        private void txtSearchNageur_TextChanged(object sender, EventArgs e)
        {
            AfficherNageur();
        }

        private void btnDetruire_Click(object sender, EventArgs e)
        {
            AfficherCompe();
        }
    }
}
