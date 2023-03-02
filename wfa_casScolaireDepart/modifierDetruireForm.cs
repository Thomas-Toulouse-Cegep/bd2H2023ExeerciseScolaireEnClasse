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
    public partial class modifierDetruireForm : Form
    {
        private ManagerCours MonManger = new ManagerCours();

        public modifierDetruireForm()
        {
            InitializeComponent();
        }

        private void remplirComboBox()
        {
            var MonManger = new ManagerCours();
            nomCoursComboBox.DataSource = MonManger.listerCours();
            nomCoursComboBox.ValueMember = "no_cours";
            nomCoursComboBox.DisplayMember = "nom_cours";
        }

        private void modifierDetruireForm_Load(object sender, EventArgs e)
        {
            remplirComboBox();
        }

        private void nomCoursComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var MonManger = new ManagerCours();
            tbl_cours cours = new tbl_cours();
            MonManger.GetCoursInformation(nomCoursComboBox.SelectedValue.ToString());
            noCoursTextBox.Text = cours.no_cours;
            nomCoursTextBox.Text = cours.nom_cours;
            ponderationTextBox.Text = cours.pond;
        }
    }
}