using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TravailBDPart4
{
    public partial class ModificationDestruction : Form
    {
        public ModificationDestruction()
        {
            InitializeComponent();
        }
        
        public void Detruire()
        {
            using (var context = new bd_natationEntities())
            {
                
                try
                 {
                    QueryEffacer();
                    MessageBox.Show("Destruction réalisée avec succès");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        public void QueryEffacer()
        {
            var id = txtIdNageur.Text;
            if (id!="")
            {
                using (var context = new bd_natationEntities())
                {
                    tbl_Nageur nageur = context.tbl_Nageur.SqlQuery("Select * FROM tbl_Nageur WHERE ID = @ID", new SqlParameter("ID", id)).FirstOrDefault();
                    context.tbl_Nageur.Remove(nageur);
                    context.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Veuillez rensigner l'ID du nageur!");
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDetruire_Click(object sender, EventArgs e)
        {
            Detruire();
        }

        private void ModificationDestruction_Load(object sender, EventArgs e)
        {
            AfficheCate();
        }

        public void AfficheCate()
        {
            using (var context = new bd_natationEntities())
            {
                cbCat.DisplayMember = "Age";
                cbCat.ValueMember = "ID";
                cbCat.DataSource = context.tbl_Categorie_Nageur.ToList();
            }

        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            tbl_Nageur nageurModif = ModifNageur();
            using (var context = new bd_natationEntities())
            {
                context.tbl_Nageur.Attach(nageurModif);
                nageurModif.Nom = txtNom.Text;
                nageurModif.Prenom = txtPrenom.Text;
                try
                {
                    if (checkH.Checked == true && checkF.Checked == false)
                    {
                        nageurModif.Genre = "M";
                    }
                    if (checkH.Checked == false && checkF.Checked == true)
                    {
                        nageurModif.Genre = "F";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " une erreur c'est produite lors de la selection du genre! Veuillez selectionner un genre!");

                }
                nageurModif.Adresse_Email = txtCouriel.Text;
                nageurModif.Id_Categorie_Nageur = findIDCategorieNageur();
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Modification effectuer!");
                }
                catch (Exception exep)
                {

                    MessageBox.Show("Erreur lors de la modification du nageur! Error: "+exep.Message);
                }
                
            }
            txtCouriel.Text = "";
            txtIdNageur.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";
            checkF.Checked = false;
            checkH.Checked = true;
        }

        private tbl_Nageur ModifNageur()
        {
            var id = txtIdNageur.Text;
            using (var context = new bd_natationEntities())
            {
                tbl_Nageur nageur = context.tbl_Nageur.SqlQuery("SELECT * FROM tbl_Nageur WHERE ID = @id", new SqlParameter("@id",id)).FirstOrDefault();
                return nageur;
            }
        }
        private int findIDCategorieNageur()
        {
            using (var context = new bd_natationEntities())
            {
                tbl_Categorie_Nageur cat = context.tbl_Categorie_Nageur.SqlQuery("SELECT ID, Age FROM tbl_Categorie_Nageur WHERE ID = @id", new SqlParameter("@id", cbCat.SelectedValue)).FirstOrDefault();
                return cat.ID;
            }
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
                    dgvNageur.Rows.Add(list[i].ID , list[i].Nom , list[i].Prenom);
                }
            }
        }

        private void txtSearchNageur_TextChanged(object sender, EventArgs e)
        {
            AfficherNageur();
        }

        private void dgvNageur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNageur_Click(object sender, EventArgs e)
        {
            txtIdNageur.Text = dgvNageur[0, dgvNageur.CurrentRow.Index].Value.ToString();
            txtNom.Text = dgvNageur[1, dgvNageur.CurrentRow.Index].Value.ToString();
            txtPrenom.Text = dgvNageur[2, dgvNageur.CurrentRow.Index].Value.ToString();
        }
    }
}
