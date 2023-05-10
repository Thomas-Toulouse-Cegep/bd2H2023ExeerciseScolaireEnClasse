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
    public partial class ParametreReturnOutputForm : Form
    {
        private Color clrBackground = Color.FromArgb(32, 32, 32);
        private Color clrFont = Color.Gray;
        private Color clrTbBack = Color.FromArgb(23, 23, 23);

        public ParametreReturnOutputForm()
        {
            InitializeComponent();
        }

        private void btnAppelStandard_Click(object sender, EventArgs e)
        {
            using (var context = new TT_BDscolaireEntities1())
            {
                var nbreCoursParSession = context.compterCours(txtSession.Text).FirstOrDefault();
                MessageBox.Show(nbreCoursParSession.ToString());
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            using (var context = new TT_BDscolaireEntities1())
            {
                var nbrCoursParSessionOutput = new System.Data.Entity.Core.Objects.ObjectParameter("nbre_cours", 0);
                context.compterCoursOutPut(txtSession.Text, nbrCoursParSessionOutput);
                MessageBox.Show(nbrCoursParSessionOutput.Value.ToString());
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            using (var context = new TT_BDscolaireEntities1())
            {
                var sql = "exec @erreurs = listerSelonNom @nom";
                var monReturn = new System.Data.SqlClient.SqlParameter("erreurs", "0");
                monReturn.Direction = ParameterDirection.Output;
                //monReturn.Value = sql;
                var nom = new System.Data.SqlClient.SqlParameter("nom", "Craciumzzzz");
                context.Database.ExecuteSqlCommand(sql, monReturn, nom);
                MessageBox.Show(monReturn.Value.ToString());
            }
        }

        private void ParametreReturnOutputForm_Load(object sender, EventArgs e)
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
            DarkNet.Instance.SetWindowThemeForms(this, Theme.Dark);
        }
    }
}