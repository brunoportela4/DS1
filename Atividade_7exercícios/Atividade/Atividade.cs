using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atividade
{
    public partial class Atividade : Form
    {
        public Atividade()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ex1 tela1 = new Ex1();
            tela1.Show();
        }

        private void tsmEx2_Click(object sender, EventArgs e)
        {
            Ex2 tela2 = new Ex2();
            tela2.Show();
        }

        private void tsmEx3_Click(object sender, EventArgs e)
        {
            Ex3 tela3 = new Ex3();
            tela3.Show();
        }

        private void tsmEx4_Click(object sender, EventArgs e)
        {
            Ex4 tela4 = new Ex4();
            tela4.Show();
        }

        private void tsmEx5_Click(object sender, EventArgs e)
        {
            Ex5 tela5 = new Ex5();
            tela5.Show();
        }

        private void tsmEx6_Click(object sender, EventArgs e)
        {
            Ex6 tela6 = new Ex6();
            tela6.Show();
        }

        private void tsmEx7_Click(object sender, EventArgs e)
        {
            Ex7 tela7 = new Ex7();
            tela7.Show();
        }
        
    }
}
