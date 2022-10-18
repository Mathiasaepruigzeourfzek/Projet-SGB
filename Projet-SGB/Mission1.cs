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
    public partial class Mission1 : Form
    {
        public Visiteur user_courant;
        public Mission1()
        {
            InitializeComponent();
        }

        private void Mission1_Load(object sender, EventArgs e)
        {
            textBox_nom_user_courant.Text = user_courant.nom;
            textBox_prenom_user_courant.Text = user_courant.prenom;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void historiqueDesBudjetsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informationsPersonnellesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_info_perso ip = new Form_info_perso();
            ip.user_courant = user_courant;
            ip.Show();
        }
    }
}
