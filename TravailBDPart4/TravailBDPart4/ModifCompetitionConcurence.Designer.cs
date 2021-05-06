
namespace TravailBDPart4
{
    partial class ModifCompetitionConcurence
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
            this.dgvCompetition = new System.Windows.Forms.DataGridView();
            this.txtDist = new System.Windows.Forms.TextBox();
            this.BtnModifDist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetition)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompetition
            // 
            this.dgvCompetition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetition.Location = new System.Drawing.Point(31, 63);
            this.dgvCompetition.Name = "dgvCompetition";
            this.dgvCompetition.Size = new System.Drawing.Size(484, 359);
            this.dgvCompetition.TabIndex = 0;
            this.dgvCompetition.Click += new System.EventHandler(this.dgvCompetition_Click);
            // 
            // txtDist
            // 
            this.txtDist.Location = new System.Drawing.Point(596, 127);
            this.txtDist.Name = "txtDist";
            this.txtDist.Size = new System.Drawing.Size(121, 20);
            this.txtDist.TabIndex = 1;
            // 
            // BtnModifDist
            // 
            this.BtnModifDist.Location = new System.Drawing.Point(596, 179);
            this.BtnModifDist.Name = "BtnModifDist";
            this.BtnModifDist.Size = new System.Drawing.Size(121, 23);
            this.BtnModifDist.TabIndex = 2;
            this.BtnModifDist.Text = "Modifier";
            this.BtnModifDist.UseVisualStyleBackColor = true;
            this.BtnModifDist.Click += new System.EventHandler(this.BtnModifDist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Distance";
            // 
            // ModifCompetitionConcurence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnModifDist);
            this.Controls.Add(this.txtDist);
            this.Controls.Add(this.dgvCompetition);
            this.Name = "ModifCompetitionConcurence";
            this.Text = "ModifCompetitionConcurence";
            this.Load += new System.EventHandler(this.ModifCompetitionConcurence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompetition;
        private System.Windows.Forms.TextBox txtDist;
        private System.Windows.Forms.Button BtnModifDist;
        private System.Windows.Forms.Label label1;
    }
}