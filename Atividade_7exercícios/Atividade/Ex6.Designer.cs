namespace Atividade
{
    partial class Ex6
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
            this.lblEnunciado6 = new System.Windows.Forms.Label();
            this.lblInserir = new System.Windows.Forms.Label();
            this.txbInsira = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEnunciado6
            // 
            this.lblEnunciado6.AutoSize = true;
            this.lblEnunciado6.Location = new System.Drawing.Point(23, 22);
            this.lblEnunciado6.Name = "lblEnunciado6";
            this.lblEnunciado6.Size = new System.Drawing.Size(520, 13);
            this.lblEnunciado6.TabIndex = 0;
            this.lblEnunciado6.Text = "Entrar com o número de vezes que se deseja imprimir a palavra “Brasil”. (Usar Loo" +
                "p – For / While / Do While)\r\n";
            // 
            // lblInserir
            // 
            this.lblInserir.AutoSize = true;
            this.lblInserir.Location = new System.Drawing.Point(206, 73);
            this.lblInserir.Name = "lblInserir";
            this.lblInserir.Size = new System.Drawing.Size(305, 13);
            this.lblInserir.TabIndex = 1;
            this.lblInserir.Text = "Insira o número de vezes que deseja imprimir a palavra \"Brasil\":";
            // 
            // txbInsira
            // 
            this.txbInsira.Location = new System.Drawing.Point(512, 70);
            this.txbInsira.Name = "txbInsira";
            this.txbInsira.Size = new System.Drawing.Size(100, 20);
            this.txbInsira.TabIndex = 2;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(640, 67);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(26, 113);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(902, 20);
            this.txbResult.TabIndex = 4;
            // 
            // Ex6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 153);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txbInsira);
            this.Controls.Add(this.lblInserir);
            this.Controls.Add(this.lblEnunciado6);
            this.Name = "Ex6";
            this.Text = "Ex6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnunciado6;
        private System.Windows.Forms.Label lblInserir;
        private System.Windows.Forms.TextBox txbInsira;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txbResult;
    }
}