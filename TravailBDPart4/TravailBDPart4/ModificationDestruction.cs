using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravailBDPart4
{
    public partial class ModificationDestruction : Form
    {
        public ModificationDestruction()
        {
            InitializeComponent();
        }

        public void Modifier()
        {
            //using (var context = new Lt_scolaireEntities())
            //{
            //    context.tbl_cours.Attach(cours);
            //    cours.no_cours = txtNocours.Text;
            //    cours.nom_cours = txtnomCours.Text;
            //    cours.pond = txtPonderation.Text;
            //    try
            //    {
            //        context.SaveChanges();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message.ToString());
            //    }
            //}

        }
        public void Detruire()
        {
            //using (var context = new Lt_scolaireEntities())
            //{
            //    cours = context.tbl_cours.Find(cmbNomCours.SelectedValue.ToString());
            //    context.tbl_cours.Remove(cours);
            //    try
            //    {
            //        context.SaveChanges();
            //        MessageBox.Show("Destruction réalisée avec succès");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message.ToString());
            //    }
            //}

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDetruire_Click(object sender, EventArgs e)
        {

        }
    }
}
