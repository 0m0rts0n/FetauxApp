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
    public partial class MainMenuDoc : Form
    {
        public MainMenuDoc()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Analysis analysis = new Analysis();
            analysis.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Indication ind = new Indication();
            ind.Show();
        }
    }
}
