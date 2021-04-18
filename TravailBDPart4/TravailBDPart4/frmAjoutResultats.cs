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
using System.Data.Entity.Infrastructure;

namespace TravailBDPart4
{
    
    public partial class frmAjoutResultats : Form
    {
        private bd_natationEntities1 context = new bd_natationEntities1();
        public frmAjoutResultats()
        {
            InitializeComponent();
        }

        private void btnAjoutResult_Click(object sender, EventArgs e)
        {

        }

        private void AfficheVue(string IdCompe)
        {
            var idCompe = new SqlParameter("@ID", IdCompe);
            string sql = "SELECT * FROM vueNageurCompe where ID = @ID";
            dgvVue.DataSource = context.vueNageurCompes.SqlQuery(sql, idCompe).ToList();
            dgvVue.Columns["ID"].Visible = false;
            dgvVue.Columns["id_nageur"].ReadOnly = true;
            dgvVue.Columns["nom"].ReadOnly = true;
            dgvVue.Columns["prenom"].ReadOnly = true;
        }

        private void frmAjoutResultats_Load(object sender, EventArgs e)
        {
            AfficheCompeCmb();
        }

        public void AfficheCompeCmb()
        {
            cmbCompetition.DisplayMember = "Nom";
            cmbCompetition.ValueMember = "ID";
            cmbCompetition.DataSource = context.tbl_Competition.ToList();
        }

        private void cmbCompetition_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficheVue(cmbCompetition.SelectedValue.ToString());
        }

        private void dgvVue_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Modifier();
        }

        private void Modifier()
        {
            try
            {
                this.Validate();
                if (context.ChangeTracker.HasChanges())
                {
                    context.SaveChanges();
                    MessageBox.Show("Mise a jour de la position effectue avec succes");
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
                ex.Entries.Single().Property("position").CurrentValue = ex.Entries.Single().Property("position").OriginalValue;
                context.SaveChanges();
            }
        }
    }
}
