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
    public partial class Form_modif_responsable_region : Form
    {
        public Visiteur user_courant;

        public Form_modif_responsable_region()
        {
            InitializeComponent();
        }

        private void Form_modif_responsable_secteur_Load(object sender, EventArgs e)
        {
            bindingSource_visiteur.DataSource = Modele.listeVisiteur();
            bindingSource_region.DataSource = Modele.listeRegion();

            comboBox_choix_region.ValueMember = "idRegion";
            comboBox_choix_region.DisplayMember = "libRegion";
            bindingSource_region.DataSource = Modele.listeRegion();
            comboBox_choix_region.DataSource = bindingSource_region;

            comboBox_choix_responsable.ValueMember = "idVisiteur";
            comboBox_choix_responsable.DisplayMember = "nom";
            bindingSource_visiteur.DataSource = Modele.listeVisiteur();
            comboBox_choix_responsable.DataSource = bindingSource_visiteur;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            int id_region = int.Parse(comboBox_choix_region.ValueMember);
            Modele.modif_responsable_region(id_region, comboBox_choix_responsable.ValueMember);
            this.Close();
        }

        private void bindingSource_region_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_choix_region_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
