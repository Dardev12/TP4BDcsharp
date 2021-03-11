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

        }
    }
}
