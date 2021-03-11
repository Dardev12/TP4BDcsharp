
namespace TravailBDPart4
{
    partial class ModificationDestruction
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
            this.checkF = new System.Windows.Forms.CheckBox();
            this.checkH = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModif = new System.Windows.Forms.Button();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtCouriel = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdNageur = new System.Windows.Forms.TextBox();
            this.btnDetruire = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvNageur = new System.Windows.Forms.DataGridView();
            this.txtSearchNageur = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNageur)).BeginInit();
            this.SuspendLayout();
            // 
            // checkF
            // 
            this.checkF.AutoSize = true;
            this.checkF.Location = new System.Drawing.Point(189, 177);
            this.checkF.Name = "checkF";
            this.checkF.Size = new System.Drawing.Size(60, 17);
            this.checkF.TabIndex = 25;
            this.checkF.Text = "Femme";
            this.checkF.UseVisualStyleBackColor = true;
            // 
            // checkH
            // 
            this.checkH.AutoSize = true;
            this.checkH.Location = new System.Drawing.Point(121, 177);
            this.checkH.Name = "checkH";
            this.checkH.Size = new System.Drawing.Size(62, 17);
            this.checkH.TabIndex = 24;
            this.checkH.Text = "Homme";
            this.checkH.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Age";
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(112, 306);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(85, 29);
            this.btnModif.TabIndex = 22;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // cbCat
            // 
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(112, 262);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(100, 21);
            this.cbCat.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Couriel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(112, 134);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 16;
            // 
            // txtCouriel
            // 
            this.txtCouriel.Location = new System.Drawing.Point(112, 216);
            this.txtCouriel.Name = "txtCouriel";
            this.txtCouriel.Size = new System.Drawing.Size(100, 20);
            this.txtCouriel.TabIndex = 15;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(112, 94);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.txtCouriel);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.txtIdNageur);
            this.groupBox1.Controls.Add(this.btnDetruire);
            this.groupBox1.Controls.Add(this.checkF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.checkH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnModif);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbCat);
            this.groupBox1.Location = new System.Drawing.Point(391, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 352);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modification";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtIdNageur
            // 
            this.txtIdNageur.Location = new System.Drawing.Point(112, 50);
            this.txtIdNageur.Name = "txtIdNageur";
            this.txtIdNageur.Size = new System.Drawing.Size(100, 20);
            this.txtIdNageur.TabIndex = 29;
            // 
            // btnDetruire
            // 
            this.btnDetruire.Location = new System.Drawing.Point(251, 45);
            this.btnDetruire.Name = "btnDetruire";
            this.btnDetruire.Size = new System.Drawing.Size(85, 29);
            this.btnDetruire.TabIndex = 26;
            this.btnDetruire.Text = "Detruire";
            this.btnDetruire.UseVisualStyleBackColor = true;
            this.btnDetruire.Click += new System.EventHandler(this.btnDetruire_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "ID Nageur";
            // 
            // dgvNageur
            // 
            this.dgvNageur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNageur.Location = new System.Drawing.Point(12, 112);
            this.dgvNageur.Name = "dgvNageur";
            this.dgvNageur.Size = new System.Drawing.Size(373, 304);
            this.dgvNageur.TabIndex = 30;
            // 
            // txtSearchNageur
            // 
            this.txtSearchNageur.Location = new System.Drawing.Point(214, 86);
            this.txtSearchNageur.Name = "txtSearchNageur";
            this.txtSearchNageur.Size = new System.Drawing.Size(171, 20);
            this.txtSearchNageur.TabIndex = 31;
            this.txtSearchNageur.TextChanged += new System.EventHandler(this.txtSearchNageur_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Search";
            // 
            // ModificationDestruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearchNageur);
            this.Controls.Add(this.dgvNageur);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificationDestruction";
            this.Text = "ModificationDestruction";
            this.Load += new System.EventHandler(this.ModificationDestruction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNageur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkF;
        private System.Windows.Forms.CheckBox checkH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtCouriel;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDetruire;
        private System.Windows.Forms.TextBox txtIdNageur;
        private System.Windows.Forms.DataGridView dgvNageur;
        private System.Windows.Forms.TextBox txtSearchNageur;
        private System.Windows.Forms.Label label7;
    }
}