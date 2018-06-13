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
    public partial class Ex7 : Form
    {
        public Ex7()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int CONT=0;
            double ALTa=1.50, ALTb=1.10;

            do{
                ALTa = ALTa + 0.02;
                ALTb = ALTb + 0.03;
                CONT ++;
            }
            while(ALTa > ALTb );

            txbResult.Text = "Demorará " + CONT + " anos."; 

        }
    }
}
