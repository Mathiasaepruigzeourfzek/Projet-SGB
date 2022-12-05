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
    public partial class page_accueil : Form
    {
        public Visiteur user_courant;
        public page_accueil()
        {
            InitializeComponent();
        }

        private void Mission1_Load(object sender, EventArgs e)
        {
            textBox_nom_user_courant.Text = user_courant.nom;
            textBox_prenom_user_courant.Text = user_courant.prenom;

            mettreAJourLesInformationsDuSecteurToolStripMenuItem.Enabled = false;
            mettreAJourLesInformationsDuSecteurToolStripMenuItem.Visible = false;

            foreach (Visiteur visiteur in Modele.listeVisiteur())
            {
                foreach (Secteur secteur in Modele.listeSecteur())
                {
                    if (secteur.idVisiteur == user_courant.idVisiteur)
                    {
                        mettreAJourLesInformationsDuSecteurToolStripMenuItem.Enabled = true;
                        mettreAJourLesInformationsDuSecteurToolStripMenuItem.Visible = true;
                        break;
                    }
                }     
            }
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

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modifierVotreMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_modif_mdp mm = new Form_modif_mdp();
            mm.user_courant = user_courant;
            mm.ShowDialog();
        }

        private void mettreAJourLesInformationsDuSecteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_info_secteur iss = new Form_info_secteur();
            iss.user_courant = user_courant;
            iss.Show();
        }

        private void mettreAJourLesInformationsDuSecteurToolStripMenuItem_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void mission3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ficheToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
