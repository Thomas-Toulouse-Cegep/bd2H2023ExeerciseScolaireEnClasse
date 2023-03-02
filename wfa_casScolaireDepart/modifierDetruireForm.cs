﻿using System;
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
    }
}