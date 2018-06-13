namespace Atividade
{
    partial class Ex7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ex7));
            this.lblEnunciado7 = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEnunciado7
            // 
            this.lblEnunciado7.AutoSize = true;
            this.lblEnunciado7.Location = new System.Drawing.Point(12, 18);
            this.lblEnunciado7.Name = "lblEnunciado7";
            this.lblEnunciado7.Size = new System.Drawing.Size(570, 39);
            this.lblEnunciado7.TabIndex = 0;
            this.lblEnunciado7.Text = resources.GetString("lblEnunciado7.Text");
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(246, 83);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "Calcular";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(15, 123);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(562, 20);
            this.txbResult.TabIndex = 2;
            // 
            // Ex7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 170);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblEnunciado7);
            this.Name = "Ex7";
            this.Text = "Ex7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnunciado7;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox txbResult;
    }
}