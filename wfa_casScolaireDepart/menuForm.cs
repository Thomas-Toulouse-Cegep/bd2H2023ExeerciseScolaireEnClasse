using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dark.Net;

namespace wfa_casScolaireDepart
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
            DarkNet.Instance.SetWindowThemeForms(this, Theme.Dark);
        }

        private void ajouterUnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouterCoursForm maForme = new ajouterCoursForm();
            DarkNet.Instance.SetWindowThemeForms(maForme, Theme.Dark);
            maForme.ShowDialog();
        }

        private void modifierdétruireUnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifierDetruireForm maForme = new modifierDetruireForm();
            maForme.ShowDialog();
        }

        private void afficherLesCoursDunEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherCourEtudiant afficherCourEtudiant = new AfficherCourEtudiant();
            afficherCourEtudiant.ShowDialog();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {
        }
    }
}