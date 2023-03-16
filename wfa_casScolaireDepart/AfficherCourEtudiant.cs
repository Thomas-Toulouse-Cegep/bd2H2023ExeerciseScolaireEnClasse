using Dark.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_casScolaireDepart
{
    public partial class AfficherCourEtudiant : Form
    {
        private Color clrBackground = Color.FromArgb(32, 32, 32);
        private Color clrFont = Color.White;
        private Color clrTbBack = Color.FromArgb(23, 23, 23);

        public AfficherCourEtudiant()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnAfficherLesCours_Click(object sender, EventArgs e)
        {
            var mangerResultat = new ManagerResultat();
            dataGridView1.DataSource = mangerResultat.listerCoursUnEtudiant_Results(txtNoDa.Text);
        }

        private void AfficherCourEtudiant_Load(object sender, EventArgs e)
        {
            this.ForeColor = clrFont;
            this.BackColor = clrBackground;
            //Now for every special-control that does need an extra color / property to be set use something like this
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.BackColor = clrTbBack;
                tb.ForeColor = clrFont;
                tb.BackColor = clrBackground;
                //Maybe do more here...
            }
            //You could now add more controls in a similar fashion.
            this.Invalidate(); //Forces a re-draw of your controls / form
            DarkNet.Instance.SetWindowThemeForms(this, Theme.Dark);
        }
    }
}