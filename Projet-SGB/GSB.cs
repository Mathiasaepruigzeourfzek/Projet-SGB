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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource_visiteur.DataSource = Modele.listeVisiteur();
            dataGridView_mdp.DataSource = bindingSource_visiteur;

            for (int i = 0; i < dataGridView_mdp.Columns.Count; i++)
            {
                dataGridView_mdp.Columns[i].Visible = false;
            }
            dataGridView_mdp.Columns[2].Visible = true;
            dataGridView_mdp.Columns[3].Visible = true;
            dataGridView_mdp.Columns[8].Visible = true;
            dataGridView_mdp.Columns[9].Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mission1 m1 = new Mission1();
            m1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mission2 m2 = new Mission2();
            m2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mission3 m3 = new Mission3();
            m3.Show();
        }

        //$requete='select * from user where login="'.$login.'" and mdpcryp=MD5("'.$password.'");';
		//$result=$connexion ->query($requete);

        private void button_ok_Click(object sender, EventArgs e)
        {
            foreach (Visiteur mdp_visiteur in Modele.listeVisiteur())
            {
                if(mdp_visiteur.password == Modele.GetMd5Hash(textBox_mdp.Text))
                {
                    if(mdp_visiteur.identifiant == textBox_identifiant.Text)
                    {
                        Mission1 m1 = new Mission1();
                        m1.user_courant = mdp_visiteur;
                        m1.Show();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Identifiant ou mot de passe invalide");
                        break;
                    }
                }
            }
            //textBox_identifiant.Text = Modele.listeVisiteur()[0].identifiant;
            //textBox_mdp.Text = Modele.listeVisiteur()[0].password;   
        }

        private void bindingSource_identifiant_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_mdp_TextChanged(object sender, EventArgs e)
        {
            textBox_hash.Text = Modele.GetMd5Hash(textBox_mdp.Text);
        }

        private void bindingSource_mdp_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
