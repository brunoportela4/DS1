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
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
        }

        private void btnDivisor_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(txbNumero.Text);
            if (num % 10 == 0)
            {
                txbResult.Text = "10".ToString();
            }
            else if (num % 5 == 0)
            {
                txbResult.Text = "5".ToString();
            }
            else if (num % 2 == 0)
            {
                txbResult.Text = "2".ToString();
            }
            else {
                txbResult.Text = "nenhum dos números citados".ToString();
            }
        }
    }
}
