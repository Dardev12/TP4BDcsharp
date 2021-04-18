
namespace TravailBDPart4
{
    partial class frmDesinscription
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchNageur = new System.Windows.Forms.TextBox();
            this.dgvNageur = new System.Windows.Forms.DataGridView();
            this.btnDesinscrire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNageur)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Search";
            // 
            // txtSearchNageur
            // 
            this.txtSearchNageur.Location = new System.Drawing.Point(285, 81);
            this.txtSearchNageur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchNageur.Name = "txtSearchNageur";
            this.txtSearchNageur.Size = new System.Drawing.Size(227, 22);
            this.txtSearchNageur.TabIndex = 34;
            this.txtSearchNageur.TextChanged += new System.EventHandler(this.txtSearchNageur_TextChanged);
            // 
            // dgvNageur
            // 
            this.dgvNageur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNageur.Location = new System.Drawing.Point(16, 113);
            this.dgvNageur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNageur.Name = "dgvNageur";
            this.dgvNageur.RowHeadersWidth = 51;
            this.dgvNageur.Size = new System.Drawing.Size(497, 374);
            this.dgvNageur.TabIndex = 33;
            // 
            // btnDesinscrire
            // 
            this.btnDesinscrire.Location = new System.Drawing.Point(604, 260);
            this.btnDesinscrire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDesinscrire.Name = "btnDesinscrire";
            this.btnDesinscrire.Size = new System.Drawing.Size(155, 52);
            this.btnDesinscrire.TabIndex = 36;
            this.btnDesinscrire.Text = "Desinscrire";
            this.btnDesinscrire.UseVisualStyleBackColor = true;
            this.btnDesinscrire.Click += new System.EventHandler(this.btnDesinscrire_Click);
            // 
            // frmDesinscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 502);
            this.Controls.Add(this.btnDesinscrire);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearchNageur);
            this.Controls.Add(this.dgvNageur);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDesinscription";
            this.Text = "spotu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNageur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchNageur;
        private System.Windows.Forms.DataGridView dgvNageur;
        private System.Windows.Forms.Button btnDesinscrire;
    }
}