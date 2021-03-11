
namespace TravailBDPart4
{
    partial class AfficherCompeNageur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCouriel = new System.Windows.Forms.TextBox();
            this.btnAfficherCompetition = new System.Windows.Forms.Button();
            this.dgvCompe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompe)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(76, 52);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 9;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(76, 12);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Couriel";
            // 
            // txtCouriel
            // 
            this.txtCouriel.Location = new System.Drawing.Point(76, 93);
            this.txtCouriel.Name = "txtCouriel";
            this.txtCouriel.Size = new System.Drawing.Size(100, 20);
            this.txtCouriel.TabIndex = 12;
            // 
            // btnAfficherCompetition
            // 
            this.btnAfficherCompetition.Location = new System.Drawing.Point(76, 150);
            this.btnAfficherCompetition.Name = "btnAfficherCompetition";
            this.btnAfficherCompetition.Size = new System.Drawing.Size(100, 35);
            this.btnAfficherCompetition.TabIndex = 14;
            this.btnAfficherCompetition.Text = "Afficher competition";
            this.btnAfficherCompetition.UseVisualStyleBackColor = true;
            // 
            // dgvCompe
            // 
            this.dgvCompe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompe.Location = new System.Drawing.Point(247, 12);
            this.dgvCompe.Name = "dgvCompe";
            this.dgvCompe.Size = new System.Drawing.Size(541, 426);
            this.dgvCompe.TabIndex = 15;
            // 
            // AfficherCompeNageur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCompe);
            this.Controls.Add(this.btnAfficherCompetition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCouriel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Name = "AfficherCompeNageur";
            this.Text = "AfficherCompeNageur";
            this.Load += new System.EventHandler(this.AfficherCompeNageur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCouriel;
        private System.Windows.Forms.Button btnAfficherCompetition;
        private System.Windows.Forms.DataGridView dgvCompe;
    }
}