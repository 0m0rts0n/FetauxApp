using System;
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
    public partial class MainMenuAdmin : Form
    {
        public MainMenuAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agencies ag = new Agencies();
            ag.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hospital h = new Hospital();
            h.Show();
        }
    }
}
