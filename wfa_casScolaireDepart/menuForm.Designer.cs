﻿namespace wfa_casScolaireDepart
{
    partial class menuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exerciceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierdétruireUnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLesCoursDunEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètreReturnOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exerciceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exerciceToolStripMenuItem
            // 
            this.exerciceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnCoursToolStripMenuItem,
            this.modifierdétruireUnCoursToolStripMenuItem,
            this.afficherLesCoursDunEtudiantToolStripMenuItem,
            this.paramètreReturnOutputToolStripMenuItem,
            this.vueToolStripMenuItem});
            this.exerciceToolStripMenuItem.Name = "exerciceToolStripMenuItem";
            this.exerciceToolStripMenuItem.Size = new System.Drawing.Size(95, 32);
            this.exerciceToolStripMenuItem.Text = "Exercice";
            // 
            // ajouterUnCoursToolStripMenuItem
            // 
            this.ajouterUnCoursToolStripMenuItem.Name = "ajouterUnCoursToolStripMenuItem";
            this.ajouterUnCoursToolStripMenuItem.Size = new System.Drawing.Size(367, 32);
            this.ajouterUnCoursToolStripMenuItem.Text = "Ajouter un cours";
            this.ajouterUnCoursToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnCoursToolStripMenuItem_Click);
            // 
            // modifierdétruireUnCoursToolStripMenuItem
            // 
            this.modifierdétruireUnCoursToolStripMenuItem.Name = "modifierdétruireUnCoursToolStripMenuItem";
            this.modifierdétruireUnCoursToolStripMenuItem.Size = new System.Drawing.Size(367, 32);
            this.modifierdétruireUnCoursToolStripMenuItem.Text = "Modifier/détruire un cours";
            this.modifierdétruireUnCoursToolStripMenuItem.Click += new System.EventHandler(this.modifierdétruireUnCoursToolStripMenuItem_Click);
            // 
            // afficherLesCoursDunEtudiantToolStripMenuItem
            // 
            this.afficherLesCoursDunEtudiantToolStripMenuItem.Name = "afficherLesCoursDunEtudiantToolStripMenuItem";
            this.afficherLesCoursDunEtudiantToolStripMenuItem.Size = new System.Drawing.Size(367, 32);
            this.afficherLesCoursDunEtudiantToolStripMenuItem.Text = "Afficher les cours d\'un etudiant";
            this.afficherLesCoursDunEtudiantToolStripMenuItem.Click += new System.EventHandler(this.afficherLesCoursDunEtudiantToolStripMenuItem_Click);
            // 
            // paramètreReturnOutputToolStripMenuItem
            // 
            this.paramètreReturnOutputToolStripMenuItem.Name = "paramètreReturnOutputToolStripMenuItem";
            this.paramètreReturnOutputToolStripMenuItem.Size = new System.Drawing.Size(367, 32);
            this.paramètreReturnOutputToolStripMenuItem.Text = "ParamètreReturn Output";
            this.paramètreReturnOutputToolStripMenuItem.Click += new System.EventHandler(this.paramètreReturnOutputToolStripMenuItem_Click);
            // 
            // vueToolStripMenuItem
            // 
            this.vueToolStripMenuItem.Name = "vueToolStripMenuItem";
            this.vueToolStripMenuItem.Size = new System.Drawing.Size(367, 32);
            this.vueToolStripMenuItem.Text = "Vue";
            this.vueToolStripMenuItem.Click += new System.EventHandler(this.vueToolStripMenuItem_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.menuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exerciceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierdétruireUnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLesCoursDunEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètreReturnOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vueToolStripMenuItem;
    }
}