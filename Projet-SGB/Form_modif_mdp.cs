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
    public partial class Form_modif_mdp : Form
    {
        public Visiteur user_courant;

        public Form_modif_mdp()
        {
            InitializeComponent();
        }

        private void Form_modif_mdp_Load(object sender, EventArgs e)
        {

        }

        private void textBox_nv_mdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            Modele.modif_mdp(user_courant, textBox_mdp_actuel.Text, textBox_nv_mdp.Text, textBox_conf_nv_mdp.Text);
            this.Close();
        }
    }
}
