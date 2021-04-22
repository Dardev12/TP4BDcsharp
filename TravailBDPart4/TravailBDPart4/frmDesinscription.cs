using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.SqlServer;

namespace TravailBDPart4
{
    public partial class frmDesinscription : Form
    {
        public frmDesinscription()
        {
            InitializeComponent();
        }

        private void txtSearchNageur_TextChanged(object sender, EventArgs e)
        {
            AfficherNageur();
        }

        private void AfficherNageur()
        {
            dgvNageur.Rows.Clear();
            dgvNageur.ColumnCount = 3;
            dgvNageur.Columns[0].Name = "ID nageur";
            dgvNageur.Columns[1].Name = "Nom";
            dgvNageur.Columns[2].Name = "Prenom";

            using (var context = new bd_natationEntities1())
            {
                List<tbl_Nageur> list = new List<tbl_Nageur>();
                list = context.tbl_Nageur.SqlQuery("SELECT * FROM tbl_Nageur WHERE nom LIKE '" + txtSearchNageur.Text + "%'").ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    dgvNageur.Rows.Add(list[i].id_nageur, list[i].Nom, list[i].Prenom);
                }
            }
        }

        private void btnDesinscrire_Click(object sender, EventArgs e)
        {
            Desinscrire();
        }

        private void Desinscrire()
        {
            
            using (var context = new bd_natationEntities1())
            {
                if (dgvNageur.CurrentCell.Value != null)
                {
                    int rowindex = dgvNageur.CurrentCell.RowIndex;
                    int columnindex = dgvNageur.CurrentCell.ColumnIndex;
                    string nageur = dgvNageur.Rows[rowindex].Cells[columnindex].Value.ToString();
                    try
                    {

                        //Code pour appeler et faire tout en rapport avec la stored proc
                        int Idnageur = int.Parse(nageur);



                        DialogResult dialogResult = MessageBox.Show("Voulez vous supprimer ce nageur", "Désincription", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //do something
                            var reponse = context.DesincriptionCompe(Idnageur);
                            MessageBox.Show("Il y a " + reponse + " nageur désincrit à cette compétition");

                            AfficherNageur();

                            txtSearchNageur.Text = "";
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else
                            MessageBox.Show("Annulation effectué");
                        }

                    }
                    catch (DataException ex)
                    {
                        MessageBox.Show(ex.InnerException.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez selectionner un nageur dans le tableau!");
                }

            }
        }

        private void frmDesinscription_Load(object sender, EventArgs e)
        {
            
        }
    }
}
