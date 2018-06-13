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
    public partial class Ex6 : Form
    {
        public Ex6()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int NUM, CONT = 1;
            NUM = int.Parse(txbInsira.Text);

            txbResult.Clear();
                do
                {
                    txbResult.Text += "Brasil ";

                    CONT++;

                }
                while (CONT <= NUM);
           
        }
    }
}
