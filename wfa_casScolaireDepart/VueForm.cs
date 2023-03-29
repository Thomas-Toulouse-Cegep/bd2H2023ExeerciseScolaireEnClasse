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
    public partial class VueForm : Form
    {
        private Color clrBackground = Color.FromArgb(32, 32, 32);
        private Color clrFont = Color.White;
        private Color clrTbBack = Color.FromArgb(23, 23, 23);

        private ManagerCours managerCours = new ManagerCours();
        private ManagerResultat managerResultat = new ManagerResultat();

        public VueForm()
        {
            DarkNet.Instance.SetWindowThemeForms(this, Theme.Dark);
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

            InitializeComponent();
        }

        private void VueForm_Load(object sender, EventArgs e)
        {
            remplirCmbCours();
        }

        private void remplirCmbCours()
        {
            try
            {
                cmbCours.DataSource = managerCours.listerCours();
                cmbCours.ValueMember = "no_cours";
                cmbCours.DisplayMember = "nom_cours";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCours_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbSession.ValueMember = "session";
            cmbSession.DisplayMember = "session";
            cmbSession.DataSource = managerResultat.ListerSession(cmbCours.SelectedValue.ToString());
          
        }
    }
}