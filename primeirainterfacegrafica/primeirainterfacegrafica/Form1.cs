using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace primeirainterfacegrafica
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Seu nome completo é: "+ txbNome.Text + " " + txbSobrenome.Text;
            MessageBox.Show("Seu nome completo é: "+ txbNome.Text + " " + txbSobrenome.Text);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int v1 = System.Convert.ToInt32(txbV1.Text);
            int v2 = System.Convert.ToInt32(txbV2.Text);
            int result;

            result = v1 + v2;

            lblResultCalc.Text = "O resultado da soma é: " + result;

        }


    }
}
