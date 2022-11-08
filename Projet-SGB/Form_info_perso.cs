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
    public partial class Form_info_perso : Form
    {
        public Visiteur user_courant;
        public Form_info_perso()
        {
            InitializeComponent();
        }

        private void Form_info_perso_Load(object sender, EventArgs e)
        {
            textBox_nom.Text = user_courant.nom;
            textBox_prenom.Text = user_courant.prenom;
            textBox_rue.Text = user_courant.rue;
            textBox_cp.Text = user_courant.cp;
            textBox_ville.Text = user_courant.ville;
            textBox_date_embauche.Text = user_courant.dateEmbauche;
        }

        private void button_modif_info_Click(object sender, EventArgs e)
        {
            Form_modif_info mi = new Form_modif_info();
            mi.user_courant = user_courant;
            mi.ShowDialog();
        }
    }
}
