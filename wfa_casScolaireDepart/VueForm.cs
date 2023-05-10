using Dark.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace wfa_casScolaireDepart
{
    public partial class VueForm : Form
    {
        private Color clrBackground = Color.FromArgb(32, 32, 32);
        private Color clrFont = Color.Gray;
        private Color clrTbBack = Color.FromArgb(23, 23, 23);
        private TT_BDscolaireEntities1 context;
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
            foreach (DataGridView tb in this.Controls.OfType<DataGridView>())
            {
                tb.BackColor = clrTbBack;
                tb.ForeColor = clrFont;
                //Maybe do more here...
            }
            foreach (ComboBox tb in this.Controls.OfType<ComboBox>())
            {
                tb.BackColor = clrTbBack;
                tb.ForeColor = clrFont;
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
            catch (DbUpdateException dbex)
            {
                MessageBox.Show(dbex.Message);
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

        private void cmbSession_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string noCours = cmbCours.SelectedValue.ToString();
            string session = cmbSession.SelectedValue.ToString();
            dgvNote.DataSource = managerResultat.ListerResultat(noCours, session, ref context);
            dgvNote.Columns["session"].Visible = false;
            dgvNote.Columns["Numéro_de_cours"].Visible = false;
            dgvNote.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNote.Columns["ID"].ReadOnly = true;
            dgvNote.Columns["Nom"].ReadOnly = true;
            dgvNote.Columns["Prenom"].ReadOnly = true;
            dgvNote.Columns["Numéro_de_cours"].ReadOnly = true;
        }

        private void dgvNote_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            enregistrer();
        }

        private void enregistrer()
        {
            try
            {
                int nbLigneAffecter = managerResultat.enregistrerLaNote(ref context);
                if (nbLigneAffecter >= 0)
                {
                    MessageBox.Show("oui");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               // throw new Exception(this.InnerException.InnerException.Message);
            }
        }
    }
}