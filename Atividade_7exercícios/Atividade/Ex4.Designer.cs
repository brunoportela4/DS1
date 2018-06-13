namespace Atividade
{
    partial class Ex4
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
            this.lblEnunciado4 = new System.Windows.Forms.Label();
            this.lblInsira = new System.Windows.Forms.Label();
            this.txbInsira = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.btnCorres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnunciado4
            // 
            this.lblEnunciado4.AutoSize = true;
            this.lblEnunciado4.Location = new System.Drawing.Point(21, 14);
            this.lblEnunciado4.Name = "lblEnunciado4";
            this.lblEnunciado4.Size = new System.Drawing.Size(332, 52);
            this.lblEnunciado4.TabIndex = 0;
            this.lblEnunciado4.Text = "Ler um número inteiro entre 1 e 12 e escrever o mês correspondente.\r\nCaso o númer" +
                "o seja fora desse intervalo, \r\ninformar que não existe mês com este número. \r\n(u" +
                "sar if) ";
            // 
            // lblInsira
            // 
            this.lblInsira.AutoSize = true;
            this.lblInsira.Location = new System.Drawing.Point(113, 105);
            this.lblInsira.Name = "lblInsira";
            this.lblInsira.Size = new System.Drawing.Size(90, 13);
            this.lblInsira.TabIndex = 1;
            this.lblInsira.Text = "Insira um número:";
            // 
            // txbInsira
            // 
            this.txbInsira.Location = new System.Drawing.Point(209, 105);
            this.txbInsira.Name = "txbInsira";
            this.txbInsira.Size = new System.Drawing.Size(100, 20);
            this.txbInsira.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(8, 188);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(170, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "O número corresponde ao mês de:";
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(184, 188);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(226, 20);
            this.txbResult.TabIndex = 4;
            // 
            // btnCorres
            // 
            this.btnCorres.Location = new System.Drawing.Point(116, 143);
            this.btnCorres.Name = "btnCorres";
            this.btnCorres.Size = new System.Drawing.Size(193, 23);
            this.btnCorres.TabIndex = 5;
            this.btnCorres.Text = "Achar mês correspondente";
            this.btnCorres.UseVisualStyleBackColor = true;
            this.btnCorres.Click += new System.EventHandler(this.btnCorres_Click);
            // 
            // Ex4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 235);
            this.Controls.Add(this.btnCorres);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txbInsira);
            this.Controls.Add(this.lblInsira);
            this.Controls.Add(this.lblEnunciado4);
            this.Name = "Ex4";
            this.Text = "Ex4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnunciado4;
        private System.Windows.Forms.Label lblInsira;
        private System.Windows.Forms.TextBox txbInsira;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.Button btnCorres;
    }
}