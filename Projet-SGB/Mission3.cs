using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_SGB
{
    public partial class Mission3 : Form
    {
        public Mission3()
        {
            InitializeComponent();
        }

        private void Mission3_Load(object sender, EventArgs e)
        {

        }

        private void btnconsulterpaye_Click(object sender, EventArgs e)
        {
            Controlefiche cf = new Controlefiche();
            cf.Show();
        }

        private void btnfichepaye_Click(object sender, EventArgs e)
        {
            Fichepaye fp = new Fichepaye();
            fp.Show();
        }
    }
}
