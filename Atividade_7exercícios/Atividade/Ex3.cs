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
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        private void btnIdentificar_Click(object sender, EventArgs e)
        {
            float A, B, C;
            A = float.Parse(txbA.Text);
            B = float.Parse(txbB.Text);
            C = float.Parse(txbC.Text);

            if(A==B && A==C){
                txbResult.Text = "Triângulo equilátero";
            }
            else if ((A == B && A != C) || (A == C && A != B) || (B == C && A != C)){
                txbResult.Text = "Triângulo isósceles";
            }
            else{
                txbResult.Text = "Triângulo escaleno";
            }
            

        }
    }
}
