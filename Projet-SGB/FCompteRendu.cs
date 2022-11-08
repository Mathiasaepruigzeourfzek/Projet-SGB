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
<<<<<<<< HEAD:Projet-SGB/Controlefiche.cs
    public partial class Controlefiche : Form
    {
        public Controlefiche()
========
    public partial class FCompteRendu : Form
    {
        public FCompteRendu()
>>>>>>>> master:Projet-SGB/FCompteRendu.cs
        {
            InitializeComponent();
        }

<<<<<<<< HEAD:Projet-SGB/Controlefiche.cs
        private void Controlefiche_Load(object sender, EventArgs e)
========
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
>>>>>>>> master:Projet-SGB/FCompteRendu.cs
        {

        }
    }
}
