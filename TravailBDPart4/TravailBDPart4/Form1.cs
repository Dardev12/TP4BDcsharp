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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void showForm(Form frm)
        {
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new Ajout());
        }

        private void modificationDestructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new ModificationDestruction());
        }

        private void afficherCompetitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new AfficherCompeNageur());
        }

        private void ajouterResultatCompetitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new frmAjoutResultats());
        }

        private void desinscrireCoureurTouteCompetitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new frmDesinscription());
        }
    }
}
