using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravailBDPart4
{
    public partial class ModifCompetitionConcurence : Form
    {
        tbl_Competition compe;
        public ModifCompetitionConcurence()
        {
            InitializeComponent();
        }

        private void ModifCompetitionConcurence_Load(object sender, EventArgs e)
        {
            AfficherNageur();
        }

        private void AfficherNageur()
        {
            dgvCompetition.Rows.Clear();

            dgvCompetition.ColumnCount = 4;
            dgvCompetition.Columns[0].Name = "ID";
            dgvCompetition.Columns[1].Name = "Nom";
            dgvCompetition.Columns[2].Name = "Description";
            dgvCompetition.Columns[3].Name = "Distance";

            dgvCompetition.Columns[0].ReadOnly = true;
            dgvCompetition.Columns[1].ReadOnly = true;
            dgvCompetition.Columns[2].ReadOnly = true;
            dgvCompetition.Columns[3].ReadOnly = true;

            using (var context = new bd_natationEntities1())
            {
                List<tbl_Competition> list = new List<tbl_Competition>();
                list = context.tbl_Competition.SqlQuery("SELECT * FROM tbl_Competition").ToList();

                for (int i = 0; i < list.Count; i++)
                {
                    dgvCompetition.Rows.Add(list[i].ID , list[i].Nom, list[i].Description, list[i].Distance);
                }
            }
        }

        private void dgvCompetition_Click(object sender, EventArgs e)
        {
            using (var context = new bd_natationEntities1())
            {
                var id = dgvCompetition[0, dgvCompetition.CurrentRow.Index].Value;
                txtDist.Text = dgvCompetition[3, dgvCompetition.CurrentRow.Index].Value.ToString();
                compe = context.tbl_Competition.SqlQuery("SELECT * FROM tbl_Competition WHERE ID = @id", new SqlParameter("@id", id)).FirstOrDefault();
            }
            
        }

        private void BtnModifDist_Click(object sender, EventArgs e)
        {
            using (var context = new bd_natationEntities1())
            {
                try
                {

                    context.tbl_Competition.Attach(compe);
                    compe.Distance  =  decimal.Parse(txtDist.Text);

                    if (context.ChangeTracker.HasChanges())
                    {
                        context.SaveChanges();
                        MessageBox.Show("Modification effectuée ");
                    }
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    var valueRecord = ex.Entries.Single();
                    decimal distanceCourant = valueRecord.CurrentValues.GetValue<decimal>("Distance");

                    decimal distanceOriginal = valueRecord.OriginalValues.GetValue<decimal>("Distance");

                    decimal distanceBD = valueRecord.GetDatabaseValues().GetValue<decimal>("Distance");

                    DialogResult reponse = MessageBox.Show("Votre  distance: "+ distanceCourant + "KM. Les valeurs d'origines étaient : " + distanceOriginal + " KM" +
                      " Les valeurs dans la BD vont etre changé pour : " + distanceBD +
                      " KM .Ecraser? ", "Il y a eu un changement dans la BD, voulez-vous enregistrer votre valeur ?"
                      , MessageBoxButtons.YesNo

                    );

                    if (reponse == DialogResult.Yes)
                    {
                        var valueBD = valueRecord.GetDatabaseValues();
                        valueRecord.OriginalValues.SetValues(valueBD);
                        context.SaveChanges();
                    }
                    else
                    {

                        valueRecord.Reload();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

       
    }
}
