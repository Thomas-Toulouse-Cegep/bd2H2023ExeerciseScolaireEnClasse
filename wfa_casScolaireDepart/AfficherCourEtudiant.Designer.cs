namespace wfa_casScolaireDepart
{
    partial class AfficherCourEtudiant
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
            this.lbNoDa = new System.Windows.Forms.Label();
            this.btnAfficherLesCours = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNoDa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNoDa
            // 
            this.lbNoDa.AutoSize = true;
            this.lbNoDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoDa.Location = new System.Drawing.Point(7, 44);
            this.lbNoDa.Name = "lbNoDa";
            this.lbNoDa.Size = new System.Drawing.Size(70, 25);
            this.lbNoDa.TabIndex = 0;
            this.lbNoDa.Text = "No DA";
            this.lbNoDa.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAfficherLesCours
            // 
            this.btnAfficherLesCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherLesCours.Location = new System.Drawing.Point(12, 107);
            this.btnAfficherLesCours.Name = "btnAfficherLesCours";
            this.btnAfficherLesCours.Size = new System.Drawing.Size(291, 37);
            this.btnAfficherLesCours.TabIndex = 1;
            this.btnAfficherLesCours.Text = "Afficher";
            this.btnAfficherLesCours.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(771, 277);
            this.dataGridView1.TabIndex = 2;
            // 
            // txtNoDa
            // 
            this.txtNoDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoDa.Location = new System.Drawing.Point(122, 44);
            this.txtNoDa.Name = "txtNoDa";
            this.txtNoDa.Size = new System.Drawing.Size(176, 30);
            this.txtNoDa.TabIndex = 3;
            // 
            // AfficherCourEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNoDa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAfficherLesCours);
            this.Controls.Add(this.lbNoDa);
            this.Name = "AfficherCourEtudiant";
            this.Text = "AfficherCourEtudiant";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNoDa;
        private System.Windows.Forms.Button btnAfficherLesCours;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNoDa;
    }
}