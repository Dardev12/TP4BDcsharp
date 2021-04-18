
namespace TravailBDPart4
{
    partial class frmAjoutResultats
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
            this.dgvVue = new System.Windows.Forms.DataGridView();
            this.cmbCompetition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVue)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVue
            // 
            this.dgvVue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVue.Location = new System.Drawing.Point(12, 85);
            this.dgvVue.Name = "dgvVue";
            this.dgvVue.Size = new System.Drawing.Size(476, 353);
            this.dgvVue.TabIndex = 0;
            this.dgvVue.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVue_CellEndEdit);
            // 
            // cmbCompetition
            // 
            this.cmbCompetition.FormattingEnabled = true;
            this.cmbCompetition.Location = new System.Drawing.Point(87, 31);
            this.cmbCompetition.Name = "cmbCompetition";
            this.cmbCompetition.Size = new System.Drawing.Size(159, 21);
            this.cmbCompetition.TabIndex = 1;
            this.cmbCompetition.SelectedIndexChanged += new System.EventHandler(this.cmbCompetition_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Competition: ";
            // 
            // frmAjoutResultats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCompetition);
            this.Controls.Add(this.dgvVue);
            this.Name = "frmAjoutResultats";
            this.Text = "frmAjoutResultats";
            this.Load += new System.EventHandler(this.frmAjoutResultats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVue;
        private System.Windows.Forms.ComboBox cmbCompetition;
        private System.Windows.Forms.Label label1;
    }
}