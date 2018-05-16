using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculadora
{
    public partial class tela : Form
    {
        public tela()
        {
            InitializeComponent();
        }

        double valor,num1,num2;
        int operacao, v=0;

        private void btn1_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 1;
            txbHistorico.Text = txbHistorico.Text + 1;
            if (v == 0)
            {
                if (num1 != 0) {
                    num1 = num1 * 10;
                }
                num1 = num1 + 1;
            }
            else {
                 if (num2 != 0) {
                    num2 = num2 * 10;
                }
                num2 = num2 + 1;
            }
               
            }
        

        private void btn2_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 2;
            txbHistorico.Text = txbHistorico.Text + 2;
            if (v == 0)
            {
                if (num1 != 0)
                {
                    num1 = num1 * 10;
                }
                num1 = num1 + 2;
            }
            else
            {
                if (num2 != 0)
                {
                    num2 = num2 * 10;
                }
                num2 = num2 + 2;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 3;
            txbHistorico.Text = txbHistorico.Text + 3;
            if (v == 0)
            {
                if (num1 != 0)
                {
                    num1 = num1 * 10;
                }
                num1 = num1 + 3;
            }
            else
            {
                if (num2 != 0)
                {
                    num2 = num2 * 10;
                }
                num2 = num2 + 3;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 4;
            txbHistorico.Text = txbHistorico.Text + 4;
            if (v == 0)
            {
                if (num1 != 0)
                {
                    num1 = num1 * 10;
                }
                num1 = num1 + 4;
            }
            else
            {
                if (num2 != 0)
                {
                    num2 = num2 * 10;
                }
                num2 = num2 + 4;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 5;
            txbHistorico.Text = txbHistorico.Text + 5;
            if (v == 0)
            {
                if (num1 != 0)
                {
                    num1 = num1 * 10;
                }
                num1 = num1 + 5;
            }
            else
            {
                if (num2 != 0)
                {
                    num2 = num2 * 10;
                }
                num2 = num2 + 5;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 6;
            txbHistorico.Text = txbHistorico.Text + 6;
            if (v == 0)
            {
                if (num1 != 0)
                {
                    num1 = num1 * 10;
                }
                num1 = num1 + 6;
            }
            else
            {
                if (num2 != 0)
                {
                    num2 = num2 * 10;
                }
                num2 = num2 + 6;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 7;
            txbHistorico.Text = txbHistorico.Text + 7;
            if (v == 0)
            {
                if (num1 != 0)
                {
                    num1 = num1 * 10;
                }
                num1 = num1 + 7;
            }
            else
            {
                if (num2 != 0)
                {
                    num2 = num2 * 10;
                }
                num2 = num2 + 7;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 8;
            txbHistorico.Text = txbHistorico.Text + 8;
            if (v == 0)
            {
                if (num1 != 0)
                {
                    num1 = num1 * 10;
                }
                num1 = num1 + 8;
            }
            else
            {
                if (num2 != 0)
                {
                    num2 = num2 * 10;
                }
                num2 = num2 + 8;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 9;
            txbHistorico.Text = txbHistorico.Text + 9;
            if (v == 0)
            {
                if (num1 != 0)
                {
                    num1 = num1 * 10;
                }
                num1 = num1 + 9;
            }
            else
            {
                if (num2 != 0)
                {
                    num2 = num2 * 10;
                }
                num2 = num2 + 9;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 0;
            txbHistorico.Text = txbHistorico.Text + 0;
            if (v == 0)
            {
                if (num1 != 0)
                {
                    num1 = num1 * 10;
                }
                num1 = num1 + 0;
            }
            else
            {
                if (num2 != 0)
                {
                    num2 = num2 * 10;
                }
                num2 = num2 + 0;
            }
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            if (v >= 1)
            {
                switch (operacao)
                {
                    case 1:
                        {
                            valor = num1 + num2;
                            txbVisor.Text = valor.ToString();
                            break;
                        }
                    case 2:
                        {
                            valor = num1 - num2;
                            txbVisor.Text = valor.ToString();
                            break;
                        }
                    case 3:
                        {
                            valor = num1 / num2;
                            txbVisor.Text = valor.ToString();
                            break;
                        }
                    case 4:
                        {
                            valor = num1 * num2;
                            txbVisor.Text = valor.ToString();
                            break;
                        }
                    default: break;
                }
                num1 = valor;
                num2 = 0;
            }

            valor = float.Parse(txbVisor.Text);
            txbVisor.Clear();
            operacao = 1;
            txbHistorico.Text = txbHistorico.Text + "+";
            v++;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (v >= 1)
            {
                switch (operacao)
                {
                    case 1:
                        {
                            valor = num1 + num2;
                            txbVisor.Text = valor.ToString();
                            break;
                        }
                    case 2:
                        {
                            valor = num1 - num2;
                            txbVisor.Text = valor.ToString();
                            break;
                        }
                    case 3:
                        {
                            valor = num1 / num2;
                            txbVisor.Text = valor.ToString();
                            break;
                        }
                    case 4:
                        {
                            valor = num1 * num2;
                            txbVisor.Text = valor.ToString();
                            break;
                        }
                    default: break;
                }
                num1 = valor;
                num2 = 0;
            }

            valor = float.Parse(txbVisor.Text);
            txbVisor.Clear();
            operacao = 2;
            txbHistorico.Text = txbHistorico.Text + "-";
            v++;

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (v >= 1)
            {
                switch (operacao)
                {
                    case 1:
                        {
                            valor = num1 + num2;
                            txbVisor.Text = valor.ToString();
                            break;
                        }
                    case 2:
                        {
                            valor = num1 - num2;
                            txbVisor.Text = valor.ToString();
                            break;
                        }
                    case 3:
                        {
                            valor = num1 / num2;
                            txbVisor.Text = valor.ToString();
                            break;
                        }
                    case 4:
                        {
                            valor = num1 * num2;
                            txbVisor.Text = valor.ToString();
                            break;
                        }
                    default: break;
                }
                num1 = valor;
                num2 = 0;
            }

            valor = float.Parse(txbVisor.Text);
            txbVisor.Clear();
            operacao = 3;
            txbHistorico.Text = txbHistorico.Text + "/";
            v++;
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            if (v >= 1)
            {
                switch (operacao)
                {
                    case 1:
                        {
                            valor = num1 + num2;
                            txbVisor.Text = valor.ToString();
                            break;
                        }
                    case 2:
                        {
                            valor = num1 - num2;
                            txbVisor.Text = valor.ToString();
                            break;
                        }
                    case 3:
                        {
                            valor = num1 / num2;
                            txbVisor.Text = valor.ToString();
                            break;
                        }
                    case 4:
                        {
                            valor = num1 * num2;
                            txbVisor.Text = valor.ToString();
                            break;
                        }
                    default: break;
                }
                num1 = valor;
                num2 = 0;
            }

            valor = float.Parse(txbVisor.Text);
            txbVisor.Clear();
            operacao = 4;
            txbHistorico.Text = txbHistorico.Text + "*";
            v++;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (operacao) {
                case 1: {
                    valor = num1+num2;
                    txbVisor.Text = valor.ToString();
                    break;
                }
                case 2:
                    {
                        valor = num1-num2;
                        txbVisor.Text = valor.ToString();
                        break;
                    }
                case 3:
                    {
                        valor = num1/num2;
                        txbVisor.Text = valor.ToString();
                        break;
                    }
                case 4:
                    {
                        valor = num1*num2;
                        txbVisor.Text = valor.ToString();
                        break;
                    }
                default : break;
            }
            num1 = valor;
            num2 = 0;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txbVisor.Clear();
            txbHistorico.Clear();
        }
    }
}
