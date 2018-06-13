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
    public partial class Ex4 : Form
    {
        public Ex4()
        {
            InitializeComponent();
        }

        private void btnCorres_Click(object sender, EventArgs e)
        {
            int MES;
            MES = int.Parse(txbInsira.Text);

            if (MES == 1)
            {
                txbResult.Text = "Janeiro";
            }
            else if (MES == 2)
            {
                txbResult.Text = "Fevereiro";
            }
            else if (MES == 3)
            {
                txbResult.Text = "Março";
            }
            else if (MES == 4)
            {
                txbResult.Text = "Abril";
            }
            else if (MES == 5)
            {
                txbResult.Text = "Maio";
            }
            else if (MES == 6)
            {
                txbResult.Text = "Junho";
            }
            else if (MES == 7)
            {
                txbResult.Text = "Julho";
            }
            else if (MES == 8)
            {
                txbResult.Text = "Agosto";
            }
            else if (MES == 9)
            {
                txbResult.Text = "Setembro";
            }
            else if (MES == 10)
            {
                txbResult.Text = "Outubro";
            }
            else if (MES == 11)
            {
                txbResult.Text = "Novembro";
            }
            else if (MES == 12)
            {
                txbResult.Text = "Dezembro";
            }
            else
            {
                txbResult.Text = "Não corresponde a nenhum mês.";
            }
            
        }
    }
}
