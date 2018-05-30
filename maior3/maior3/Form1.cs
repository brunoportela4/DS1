using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace maior3
{
    public partial class frmMaiorValorDeTres : Form
    {
        public frmMaiorValorDeTres()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double ValorA = System.Convert.ToDouble(txbValorA.Text);
            double ValorB = System.Convert.ToDouble(txbValorB.Text);
            double ValorC = System.Convert.ToDouble(txbValorC.Text);

            if (ValorA > ValorB && ValorA > ValorC)
            {
                lblResposta.Text = "O maior valor é A!";
            }
            else if (ValorB > ValorA && ValorB > ValorC)
            {
                lblResposta.Text = "O maior valor é B!";
            }
            else if (ValorC > ValorB && ValorC > ValorA)
            {
                lblResposta.Text = "O maior valor é C!";
            }
            else {
                lblResposta.Text = "Empate técnico!";
            }
        }
    }
}
