﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FetauxApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginTB.Text == "doc" && passwordTB.Text == "doc") { MainMenuDoc mmd = new MainMenuDoc(); mmd.Show(); }

            if (loginTB.Text == "test" && passwordTB.Text == "test") { WatchPatientForm wpf = new WatchPatientForm(); wpf.Show(); }

            if (loginTB.Text == "admin" && passwordTB.Text == "admin") { MainMenuAdmin mma = new MainMenuAdmin(); mma.Show(); }
        }
    }
}
