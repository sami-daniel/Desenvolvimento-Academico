namespace Ex03Pag0
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnstrucao = new System.Windows.Forms.Label();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnstrucao
            // 
            this.lblnstrucao.AutoSize = true;
            this.lblnstrucao.Location = new System.Drawing.Point(88, 29);
            this.lblnstrucao.Name = "lblnstrucao";
            this.lblnstrucao.Size = new System.Drawing.Size(155, 13);
            this.lblnstrucao.TabIndex = 0;
            this.lblnstrucao.Text = "Quantos kilos o cliente comeu: ";
            // 
            // txtKg
            // 
            this.txtKg.Location = new System.Drawing.Point(113, 62);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(100, 20);
            this.txtKg.TabIndex = 1;
            this.txtKg.TextChanged += new System.EventHandler(this.txtKg_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Caucular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 188);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKg);
            this.Controls.Add(this.lblnstrucao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnstrucao;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

