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
    public partial class Form_info_secteur : Form
    {
        public Visiteur user_courant;

        public Form_info_secteur()
        {
            InitializeComponent();
        }

        private void Form_info_secteur_Load(object sender, EventArgs e)
        {
            /*bindingSource_compositeur.DataSource = ((NATIONALITE)bindingSource_nation.Current).COMPOSITEUR.Select(x => new { x.nomCompositeur, x.prenomCompositeur, x.STYLE.libStyle, x.anNais, x.anMort, x.remarque, x.idCompositeur }).OrderBy(x => x.nomCompositeur);
            dataGridView_compositeur_nation.DataSource = bindingSource_compositeur;*/

            bindingSource_visiteur.DataSource = Modele.listeVisiteur();
            dataGridView_liste_visiteur_secteur.DataSource = bindingSource_visiteur;

            for (int i = 0; i < dataGridView_liste_visiteur_secteur.Columns.Count; i++)
            {
                dataGridView_liste_visiteur_secteur.Columns[i].Visible = false;
            }
            dataGridView_liste_visiteur_secteur.Columns[2].Visible = true;
            dataGridView_liste_visiteur_secteur.Columns[3].Visible = true;
        }

        private void button_modif_responsable_secteur_Click(object sender, EventArgs e)
        {
            Form_modif_responsable_region mrs = new Form_modif_responsable_region();
            mrs.user_courant = user_courant;
            mrs.ShowDialog();
        }

        private void bindingSource_visiteur_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
