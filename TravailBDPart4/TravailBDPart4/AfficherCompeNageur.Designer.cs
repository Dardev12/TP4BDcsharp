
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
            this.dgvCompe = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchNageur = new System.Windows.Forms.TextBox();
            this.dgvNageur = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDetruire = new System.Windows.Forms.Button();
            this.txtIdNageur = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNageur)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCompe
            // 
            this.dgvCompe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompe.Location = new System.Drawing.Point(841, 12);
            this.dgvCompe.Name = "dgvCompe";
            this.dgvCompe.Size = new System.Drawing.Size(541, 589);
            this.dgvCompe.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Search";
            // 
            // txtSearchNageur
            // 
            this.txtSearchNageur.Location = new System.Drawing.Point(242, 127);
            this.txtSearchNageur.Name = "txtSearchNageur";
            this.txtSearchNageur.Size = new System.Drawing.Size(171, 20);
            this.txtSearchNageur.TabIndex = 35;
            this.txtSearchNageur.TextChanged += new System.EventHandler(this.txtSearchNageur_TextChanged);
            // 
            // dgvNageur
            // 
            this.dgvNageur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNageur.Location = new System.Drawing.Point(40, 153);
            this.dgvNageur.Name = "dgvNageur";
            this.dgvNageur.Size = new System.Drawing.Size(373, 304);
            this.dgvNageur.TabIndex = 34;
            this.dgvNageur.Click += new System.EventHandler(this.dgvNageur_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Prenom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "ID Nageur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nom";
            // 
            // btnDetruire
            // 
            this.btnDetruire.Location = new System.Drawing.Point(271, 163);
            this.btnDetruire.Name = "btnDetruire";
            this.btnDetruire.Size = new System.Drawing.Size(92, 38);
            this.btnDetruire.TabIndex = 26;
            this.btnDetruire.Text = "Afficher Competition";
            this.btnDetruire.UseVisualStyleBackColor = true;
            this.btnDetruire.Click += new System.EventHandler(this.btnDetruire_Click);
            // 
            // txtIdNageur
            // 
            this.txtIdNageur.Location = new System.Drawing.Point(111, 129);
            this.txtIdNageur.Name = "txtIdNageur";
            this.txtIdNageur.Size = new System.Drawing.Size(100, 20);
            this.txtIdNageur.TabIndex = 29;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(111, 213);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 16;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(111, 173);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.txtIdNageur);
            this.groupBox1.Controls.Add(this.btnDetruire);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(419, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 352);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modification";
            // 
            // AfficherCompeNageur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 613);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearchNageur);
            this.Controls.Add(this.dgvNageur);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCompe);
            this.Name = "AfficherCompeNageur";
            this.Text = "AfficherCompeNageur";
            this.Load += new System.EventHandler(this.AfficherCompeNageur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNageur)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCompe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchNageur;
        private System.Windows.Forms.DataGridView dgvNageur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDetruire;
        private System.Windows.Forms.TextBox txtIdNageur;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}