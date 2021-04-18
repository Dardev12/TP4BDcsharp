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
    public partial class Ajout : Form
    {
        public Ajout()
        {
            InitializeComponent();
        }
        tbl_Nageur nageur;

        public object Row { get; private set; }

        public void Ajoute()
        {
            using (var context = new bd_natationEntities1())
            {
                
                nageur = new tbl_Nageur();
                nageur.Nom = txtNom.Text;
                nageur.Prenom = txtPrenom.Text;
                try
                {
                    if (checkH.Checked == true && checkF.Checked == false)
                    {
                        nageur.Genre = "M";
                    }
                    if (checkH.Checked == false && checkF.Checked == true)
                    {
                        nageur.Genre = "F";
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + " une erreur c'est produite lors de la selection du genre! Veuillez selectionner un genre!");
                    
                }
                
                
                nageur.Adresse_Email = txtCouriel.Text;
                nageur.Id_Categorie_Nageur = findIDCategorieNageur();
                context.tbl_Nageur.Add(nageur);
                if (context.tbl_Nageur.Any(n => n.Adresse_Email == nageur.Adresse_Email))
                {
                    MessageBox.Show("Le nageur existe deja! Veuillez le modifier ou le suprimer!");
                }
                else
                {
                    try
                    {
                        context.SaveChanges();
                        MessageBox.Show("Enregistrement réalisé avec succès");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur c'est produite lors de l'ajout: " + ex.Message.ToString());
                    }
                }
                
            }
        }

        public void AfficheCate()
        {
            using (var context = new bd_natationEntities1())
            {
                cbCat.DisplayMember = "Age";
                cbCat.ValueMember = "ID";
                cbCat.DataSource = context.tbl_Categorie_Nageur.ToList();
            }
            
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            Ajoute();
        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbIdCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Ajout_Load(object sender, EventArgs e)
        {
            AfficheCate();
        }
        private int findIDCategorieNageur()
        {
            using (var context = new bd_natationEntities1())
            {
                tbl_Categorie_Nageur cat = context.tbl_Categorie_Nageur.SqlQuery("SELECT ID, Age FROM tbl_Categorie_Nageur WHERE ID = @id", new SqlParameter("@id", cbCat.SelectedValue)).FirstOrDefault();
                return cat.ID;
            }
        }
    }
}

