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
    public partial class Histogramme : Form
    {
        public Histogramme()
        {
            InitializeComponent();
        }

        private void Histogramme_Load(object sender, EventArgs e)
        {
            CrystalReport1 cr = new CrystalReport1();
            
            crystalReportViewer1.ReportSource=cr;
        }
    }
}
