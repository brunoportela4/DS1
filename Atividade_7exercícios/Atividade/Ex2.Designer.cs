namespace Atividade
{
    partial class Ex2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEnunciado2 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.lblInserir = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.btnDivisor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnunciado2
            // 
            this.lblEnunciado2.AutoSize = true;
            this.lblEnunciado2.Location = new System.Drawing.Point(13, 13);
            this.lblEnunciado2.Name = "lblEnunciado2";
            this.lblEnunciado2.Size = new System.Drawing.Size(283, 39);
            this.lblEnunciado2.TabIndex = 0;
            this.lblEnunciado2.Text = "Entrar com um número e informar se ele é divisível por 10, \r\npor 5, por 2 ou se n" +
                "ão é divisível por nenhum destes.\r\n(usar mod = exemplo 4%2)";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(113, 87);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 1;
            // 
            // lblInserir
            // 
            this.lblInserir.AutoSize = true;
            this.lblInserir.Location = new System.Drawing.Point(119, 68);
            this.lblInserir.Name = "lblInserir";
            this.lblInserir.Size = new System.Drawing.Size(90, 13);
            this.lblInserir.TabIndex = 2;
            this.lblInserir.Text = "Insira um número:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(91, 162);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(140, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Esse número é divisível por:";
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(16, 182);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(280, 20);
            this.txbResult.TabIndex = 3;
            // 
            // btnDivisor
            // 
            this.btnDivisor.Location = new System.Drawing.Point(91, 123);
            this.btnDivisor.Name = "btnDivisor";
            this.btnDivisor.Size = new System.Drawing.Size(140, 23);
            this.btnDivisor.TabIndex = 5;
            this.btnDivisor.Text = "Encontrar divisor";
            this.btnDivisor.UseVisualStyleBackColor = true;
            this.btnDivisor.Click += new System.EventHandler(this.btnDivisor_Click);
            // 
            // Ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 226);
            this.Controls.Add(this.btnDivisor);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.lblInserir);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.lblEnunciado2);
            this.Name = "Ex2";
            this.Text = "Ex2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnunciado2;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label lblInserir;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.Button btnDivisor;
    }
}