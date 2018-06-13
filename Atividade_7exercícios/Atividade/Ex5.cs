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
    public partial class Ex5 : Form
    {
        public Ex5()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int NUM, CONT=1;
            NUM = int.Parse(txbInsira.Text);
            
            txbResult.Clear();
            
            if (NUM > 50)
            {
                txbResult.Text = "Número maior que o permitido";
            }
            else { 
               
                do{
                    txbResult.Text += CONT + ", ";

                      CONT++;
                      
                }
                while(CONT <= NUM);
            }
        }
    }
}
