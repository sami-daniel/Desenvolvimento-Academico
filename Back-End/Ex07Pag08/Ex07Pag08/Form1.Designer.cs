namespace Ex07Pag08
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
            this.lblIindicacao = new System.Windows.Forms.Label();
            this.txtCamisas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIindicacao
            // 
            this.lblIindicacao.AutoSize = true;
            this.lblIindicacao.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIindicacao.Location = new System.Drawing.Point(119, 84);
            this.lblIindicacao.Name = "lblIindicacao";
            this.lblIindicacao.Size = new System.Drawing.Size(13, 21);
            this.lblIindicacao.TabIndex = 0;
            this.lblIindicacao.Text = ",";
            this.lblIindicacao.Click += new System.EventHandler(this.lblIindicacao_Click);
            // 
            // txtCamisas
            // 
            this.txtCamisas.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCamisas.Location = new System.Drawing.Point(165, 128);
            this.txtCamisas.Name = "txtCamisas";
            this.txtCamisas.Size = new System.Drawing.Size(100, 30);
            this.txtCamisas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "VALOR DE VENDA";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(177, 181);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 3;
            this.btnCal.Text = "Adicionar";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(151, 268);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 21);
            this.lblResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 298);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCamisas);
            this.Controls.Add(this.lblIindicacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIindicacao;
        private System.Windows.Forms.TextBox txtCamisas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label lblResult;
    }
}

