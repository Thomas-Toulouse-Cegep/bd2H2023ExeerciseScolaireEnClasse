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
        private Color clrBackground = Color.FromArgb(32, 32, 32);
        private Color clrFont = Color.White;
        private Color clrTbBack = Color.FromArgb(23, 23, 23);

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
            this.ForeColor = clrFont;
            this.BackColor = clrBackground;
            //Now for every special-control that does need an extra color / property to be set use something like this
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.BackColor = clrTbBack;
                //Maybe do more here...
            }
            //You could now add more controls in a similar fashion.
            this.Invalidate(); //Forces a re-draw of your controls / form
        }

        private void paramètreReturnOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParametreReturnOutputForm param = new ParametreReturnOutputForm();
            param.ShowDialog();
        }
    }
}