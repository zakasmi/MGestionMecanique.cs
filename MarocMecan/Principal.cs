using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarocMecan
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void materielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materiel CM = new Materiel();
            CM.ShowDialog();

        }

        private void reparationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reparation R = new Reparation();
            R.ShowDialog();

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
