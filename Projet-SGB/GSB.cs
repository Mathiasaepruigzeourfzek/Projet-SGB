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
    }
}
