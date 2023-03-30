namespace wfa_casScolaireDepart
{
    partial class VueForm
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
            this.dgvNote = new System.Windows.Forms.DataGridView();
            this.cmbCours = new System.Windows.Forms.ComboBox();
            this.lbno_cours = new System.Windows.Forms.Label();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.lbSession = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNote
            // 
            this.dgvNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNote.Location = new System.Drawing.Point(15, 284);
            this.dgvNote.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNote.Name = "dgvNote";
            this.dgvNote.RowHeadersWidth = 51;
            this.dgvNote.RowTemplate.Height = 24;
            this.dgvNote.Size = new System.Drawing.Size(970, 318);
            this.dgvNote.TabIndex = 0;
            this.dgvNote.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNote_CellEndEdit);
            // 
            // cmbCours
            // 
            this.cmbCours.FormattingEnabled = true;
            this.cmbCours.Location = new System.Drawing.Point(148, 61);
            this.cmbCours.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCours.Name = "cmbCours";
            this.cmbCours.Size = new System.Drawing.Size(836, 30);
            this.cmbCours.TabIndex = 1;
            this.cmbCours.SelectionChangeCommitted += new System.EventHandler(this.cmbCours_SelectionChangeCommitted);
            // 
            // lbno_cours
            // 
            this.lbno_cours.AutoSize = true;
            this.lbno_cours.Location = new System.Drawing.Point(26, 65);
            this.lbno_cours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbno_cours.Name = "lbno_cours";
            this.lbno_cours.Size = new System.Drawing.Size(84, 22);
            this.lbno_cours.TabIndex = 2;
            this.lbno_cours.Text = "no_cours";
            // 
            // cmbSession
            // 
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Location = new System.Drawing.Point(148, 161);
            this.cmbSession.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(836, 30);
            this.cmbSession.TabIndex = 3;
            this.cmbSession.SelectionChangeCommitted += new System.EventHandler(this.cmbSession_SelectionChangeCommitted);
            // 
            // lbSession
            // 
            this.lbSession.AutoSize = true;
            this.lbSession.Location = new System.Drawing.Point(26, 165);
            this.lbSession.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSession.Name = "lbSession";
            this.lbSession.Size = new System.Drawing.Size(74, 22);
            this.lbSession.TabIndex = 4;
            this.lbSession.Text = "Session";
            // 
            // VueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.lbSession);
            this.Controls.Add(this.cmbSession);
            this.Controls.Add(this.lbno_cours);
            this.Controls.Add(this.cmbCours);
            this.Controls.Add(this.dgvNote);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VueForm";
            this.Text = "VueForm";
            this.Load += new System.EventHandler(this.VueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNote;
        private System.Windows.Forms.ComboBox cmbCours;
        private System.Windows.Forms.Label lbno_cours;
        private System.Windows.Forms.ComboBox cmbSession;
        private System.Windows.Forms.Label lbSession;
    }
}