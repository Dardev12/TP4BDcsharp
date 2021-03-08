
namespace TravailBDPart4
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationDestructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherCompetitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutToolStripMenuItem,
            this.modificationDestructionToolStripMenuItem,
            this.afficherCompetitionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajoutToolStripMenuItem
            // 
            this.ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            this.ajoutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ajoutToolStripMenuItem.Text = "Ajout";
            this.ajoutToolStripMenuItem.Click += new System.EventHandler(this.ajoutToolStripMenuItem_Click);
            // 
            // modificationDestructionToolStripMenuItem
            // 
            this.modificationDestructionToolStripMenuItem.Name = "modificationDestructionToolStripMenuItem";
            this.modificationDestructionToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.modificationDestructionToolStripMenuItem.Text = "Modification/Destruction";
            this.modificationDestructionToolStripMenuItem.Click += new System.EventHandler(this.modificationDestructionToolStripMenuItem_Click);
            // 
            // afficherCompetitionToolStripMenuItem
            // 
            this.afficherCompetitionToolStripMenuItem.Name = "afficherCompetitionToolStripMenuItem";
            this.afficherCompetitionToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.afficherCompetitionToolStripMenuItem.Text = "AfficherCompetition";
            this.afficherCompetitionToolStripMenuItem.Click += new System.EventHandler(this.afficherCompetitionToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 410);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationDestructionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherCompetitionToolStripMenuItem;
    }
}

