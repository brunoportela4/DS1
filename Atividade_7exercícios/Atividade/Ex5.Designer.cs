namespace Atividade
{
    partial class Ex5
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
            this.lblEnunciado5 = new System.Windows.Forms.Label();
            this.lblInsira = new System.Windows.Forms.Label();
            this.txbInsira = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEnunciado5
            // 
            this.lblEnunciado5.AutoSize = true;
            this.lblEnunciado5.Location = new System.Drawing.Point(25, 21);
            this.lblEnunciado5.Name = "lblEnunciado5";
            this.lblEnunciado5.Size = new System.Drawing.Size(660, 13);
            this.lblEnunciado5.TabIndex = 0;
            this.lblEnunciado5.Text = "Criar um algoritmos que leia um número até 50 e imprima todos os número de 1 até " +
                "o número digitado. (Usar Loop – For / While / Do While)";
            // 
            // lblInsira
            // 
            this.lblInsira.AutoSize = true;
            this.lblInsira.Location = new System.Drawing.Point(337, 72);
            this.lblInsira.Name = "lblInsira";
            this.lblInsira.Size = new System.Drawing.Size(129, 13);
            this.lblInsira.TabIndex = 1;
            this.lblInsira.Text = "Insira um número (até 50):";
            // 
            // txbInsira
            // 
            this.txbInsira.Location = new System.Drawing.Point(474, 70);
            this.txbInsira.Name = "txbInsira";
            this.txbInsira.Size = new System.Drawing.Size(100, 20);
            this.txbInsira.TabIndex = 2;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(598, 68);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "Imprimir";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(18, 99);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(969, 20);
            this.txbResult.TabIndex = 4;
            // 
            // Ex5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 139);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txbInsira);
            this.Controls.Add(this.lblInsira);
            this.Controls.Add(this.lblEnunciado5);
            this.Name = "Ex5";
            this.Text = "Ex5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnunciado5;
        private System.Windows.Forms.Label lblInsira;
        private System.Windows.Forms.TextBox txbInsira;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox txbResult;
    }
}