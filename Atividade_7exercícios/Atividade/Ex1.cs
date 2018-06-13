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
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            float num1, num2, result;
            num1 = float.Parse(txb1.Text);
            num2 = float.Parse(txb2.Text);
            result = num1 + num2;
            if (result > 20)
            {
                result = result + 8;
                txbResult.Text = result.ToString();
            }
            else {
                result = result - 5;
                txbResult.Text = result.ToString();
            }
        }
    }
}
